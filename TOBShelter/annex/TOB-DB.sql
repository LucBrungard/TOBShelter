SET NAMES utf8mb4 ;

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `tob_db` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `tob_db`;

DROP TABLE IF EXISTS `photo_links`;
DROP TABLE IF EXISTS `activities`;
DROP TABLE IF EXISTS `documents`;
DROP TABLE IF EXISTS `links_animals_investigations`;
DROP TABLE IF EXISTS `animals`;
DROP TABLE IF EXISTS `investigations`;
DROP TABLE IF EXISTS `investigators`;
DROP TABLE IF EXISTS `persons`;

SET character_set_client = utf8mb4 ;
CREATE TABLE `persons` (
    `person_id` int(11) UNIQUE AUTO_INCREMENT,
    `title` ENUM('M', 'Mme', 'Societe') NOT NULL,
    `name` varchar(255) NOT NULL,
    `first_name` varchar(255),
    `mobile` varchar(255),
    `home` varchar(255),
    `email` varchar(255),
    `no_route` varchar(255) NOT NULL,
    `route_type` ENUM('RUE','BOULEVARD','AVENUE','IMPASSE','ALLEE','COURS') NOT NULL,
    `route_name` varchar(255) NOT NULL,
    `postal_code` varchar(6) NOT NULL,
    `city` varchar(255) NOT NULL,
    PRIMARY KEY (`title`, `name`, `first_name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

SET character_set_client = utf8mb4 ;
CREATE TABLE `animals` (
    `animal_id` int(11) AUTO_INCREMENT,
    `type` varchar(255) NOT NULL,
    `name` varchar(255),
    `age` int(3),
    `weight` varchar(255),
    `gender` ENUM('M', 'F'),
    `race` varchar(255),
    `owner` int(11) NOT NULL,
    PRIMARY KEY (`animal_id`),
    KEY `owner` (`owner`),
    CONSTRAINT `animals_ownerfk_1` FOREIGN KEY (`owner`) REFERENCES `persons` (`person_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `investigators`;
SET character_set_client = utf8mb4 ;
CREATE TABLE `investigators` (
    `available` tinyint(1) NOT NULL,
    `in_operation` tinyint(1) NOT NULL,
    `business_sector` varchar(500) NOT NULL,
    `person_id` int(11) NOT NULL,
    KEY `person_id` (`person_id`),
    CONSTRAINT `investigators_person_idfk_1` FOREIGN KEY (`person_id`) REFERENCES `persons` (`person_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

SET character_set_client = utf8mb4 ;
CREATE TABLE `investigations` (
    `investigation_id` int(11) AUTO_INCREMENT,
    `title` varchar(255) NOT NULL,
    `complainant` int(11) NOT NULL,
    `offender` int(11) NOT NULL,
    `reason` varchar(500) NOT NULL,
    `investigator` int(11) NOT NULL,
    `notice` varchar(255),
    `closed` tinyint(1) NOT NULL,
    PRIMARY KEY (`investigation_id`),
    KEY `complainant` (`complainant`),
    CONSTRAINT `investigations_complainantfk_1` FOREIGN KEY (`complainant`) REFERENCES `persons` (`person_id`),
    KEY `offender` (`offender`),
    CONSTRAINT `investigations_offenderfk_1` FOREIGN KEY (`offender`) REFERENCES `persons` (`person_id`),
    KEY `investigator` (`investigator`),
    CONSTRAINT `investigations_investigatorfk_1` FOREIGN KEY (`investigator`) REFERENCES `investigators` (`person_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

SET character_set_client = utf8mb4 ;
CREATE TABLE `links_animals_investigations` (
    `animal_id` int(11) NOT NULL,
    `investigation_id` int(11) NOT NULL,
    PRIMARY KEY (`animal_id`, `investigation_id`),
    KEY `animal_id` (`animal_id`),
    KEY `investigation_id` (`investigation_id`),
    CONSTRAINT `links_animals_investigations_animal_idfk` FOREIGN KEY (`animal_id`) REFERENCES `animals` (`animal_id`),
    CONSTRAINT `links_animals_investigations_investigation_idfk` FOREIGN KEY (`investigation_id`) REFERENCES `investigations` (`investigation_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

SET character_set_client = utf8mb4 ;
CREATE TABLE `documents` (
    `document_id` int(11)  AUTO_INCREMENT,
    `path` varchar(255) NOT NULL,
    `investigation_id` int(11) NOT NULL,
    PRIMARY KEY (`document_id`),
    KEY `investigation_id` (`investigation_id`),     
    CONSTRAINT `documents_investigationfk_1` FOREIGN KEY (`investigation_id`) REFERENCES `investigations` (`investigation_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

SET character_set_client = utf8mb4 ;
CREATE TABLE `activities` (
    `activity_id` int(11) AUTO_INCREMENT,
    `date` date NOT NULL,
    `description` varchar(500),
    `type` ENUM('commentary', 'phone_call', 'notice_of_visit', 'visit', 'photo') NOT NULL,
    `investigation_id` int(11) NOT NULL,
    PRIMARY KEY (`activity_id`),
    KEY `investigation_id` (`investigation_id`),     
    CONSTRAINT `activities_investigationfk_1` FOREIGN KEY (`investigation_id`) REFERENCES `investigations` (`investigation_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

SET character_set_client = utf8mb4 ;
CREATE TABLE `photo_links` (
    `photo_link_id` int(11) AUTO_INCREMENT,
    `path` varchar(255) NOT NULL,
    `activity_id` int(11) NOT NULL,
    PRIMARY KEY (`photo_link_id`),
    KEY `activity_id` (`activity_id`),
    CONSTRAINT `photo_links_activityfk_1` FOREIGN KEY (`activity_id`) REFERENCES `activities` (`activity_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
