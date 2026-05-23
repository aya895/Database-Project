/*==============================================================*/
/* DROP FOREIGN KEYS                                            */
/*==============================================================*/

IF OBJECT_ID('FK_EXPERIEN_DOES_CONCIERG', 'F') IS NOT NULL
ALTER TABLE EXPERIENCE DROP CONSTRAINT FK_EXPERIEN_DOES_CONCIERG;
GO

IF OBJECT_ID('FK_RESERVAT_BOOK_SUITE', 'F') IS NOT NULL
ALTER TABLE RESERVATION DROP CONSTRAINT FK_RESERVAT_BOOK_SUITE;
GO

IF OBJECT_ID('FK_RESERVAT_BOOKS_GUEST', 'F') IS NOT NULL
ALTER TABLE RESERVATION DROP CONSTRAINT FK_RESERVAT_BOOKS_GUEST;
GO

IF OBJECT_ID('FK_RESERVAT_CONTAINS_EXPERIEN', 'F') IS NOT NULL
ALTER TABLE RESERVATION_EXPERIENCE DROP CONSTRAINT FK_RESERVAT_CONTAINS_EXPERIEN;
GO

IF OBJECT_ID('FK_RESERVAT_CREATES_RESERVAT', 'F') IS NOT NULL
ALTER TABLE RESERVATION_EXPERIENCE DROP CONSTRAINT FK_RESERVAT_CREATES_RESERVAT;
GO

IF OBJECT_ID('FK_SUITE_HAS_HOTEL', 'F') IS NOT NULL
ALTER TABLE SUITE DROP CONSTRAINT FK_SUITE_HAS_HOTEL;
GO


/*==============================================================*/
/* DROP TABLES                                                  */
/*==============================================================*/

DROP TABLE IF EXISTS RESERVATION_EXPERIENCE;
GO

DROP TABLE IF EXISTS RESERVATION;
GO

DROP TABLE IF EXISTS EXPERIENCE;
GO

DROP TABLE IF EXISTS SUITE;
GO

DROP TABLE IF EXISTS GUEST;
GO

DROP TABLE IF EXISTS CONCIERGE;
GO

DROP TABLE IF EXISTS HOTEL;
GO


/*==============================================================*/
/* TABLE: CONCIERGE                                             */
/*==============================================================*/

CREATE TABLE CONCIERGE
(
    CONCIERGE_ID       INT NOT NULL,
    CONCIERGE_NAME     VARCHAR(50) NOT NULL,
    SPECIALIZED_SKILLS VARCHAR(100),

    CONSTRAINT PK_CONCIERGE
    PRIMARY KEY (CONCIERGE_ID)
);
GO


/*==============================================================*/
/* TABLE: EXPERIENCE                                            */
/*==============================================================*/

CREATE TABLE EXPERIENCE
(
    EXPERIENCE_ID      INT NOT NULL,
    CONCIERGE_ID       INT NOT NULL,
    EXPERIENCE_NAME    VARCHAR(50) NOT NULL,
    DESCRIPTION        VARCHAR(100),

    CONSTRAINT PK_EXPERIENCE
    PRIMARY KEY (EXPERIENCE_ID)
);
GO


/*==============================================================*/
/* TABLE: GUEST                                                 */
/*==============================================================*/

CREATE TABLE GUEST
(
    GUEST_ID           INT NOT NULL,
    GUEST_NAME         VARCHAR(50) NOT NULL,
    EMAIL              VARCHAR(100),
    PHONE              VARCHAR(20),
    REGISTRATION_DATE  DATE NOT NULL,
    BILLING_ADDRESS    VARCHAR(100),

    CONSTRAINT PK_GUEST
    PRIMARY KEY (GUEST_ID)
);
GO


/*==============================================================*/
/* TABLE: HOTEL                                                 */
/*==============================================================*/

CREATE TABLE HOTEL
(
    HOTEL_ID           INT NOT NULL,
    HOTEL_NAME         VARCHAR(50) NOT NULL,
    LOCATION           VARCHAR(100),
    THEME              VARCHAR(40) NOT NULL,

    CONSTRAINT PK_HOTEL
    PRIMARY KEY (HOTEL_ID)
);
GO


/*==============================================================*/
/* TABLE: SUITE                                                 */
/*==============================================================*/

CREATE TABLE SUITE
(
    SUITE_ID           INT NOT NULL,
    HOTEL_ID           INT NOT NULL,
    SUITE_NUMBER       INT NOT NULL,
    SUITE_CLASS        VARCHAR(50),
    PRICE_PER_NIGHT    DECIMAL(10,2),
    AMENITIES          VARCHAR(200),

    CONSTRAINT PK_SUITE
    PRIMARY KEY (SUITE_ID)
);
GO


/*==============================================================*/
/* TABLE: RESERVATION                                           */
/*==============================================================*/

CREATE TABLE RESERVATION
(
    RESERVATION_ID      INT NOT NULL,
    GUEST_ID            INT NOT NULL,
    SUITE_ID            INT NOT NULL,
    START_DATE          DATE,
    END_DATE            DATE,
    TOTAL_PRICE         DECIMAL(10,2),
    RESERVATION_STATUS  VARCHAR(20),

    CONSTRAINT PK_RESERVATION
    PRIMARY KEY (RESERVATION_ID)
);
GO


/*==============================================================*/
/* TABLE: RESERVATION_EXPERIENCE                                */
/*==============================================================*/

CREATE TABLE RESERVATION_EXPERIENCE
(
    RES_EXP_ID         INT NOT NULL,
    EXPERIENCE_ID      INT NOT NULL,
    RESERVATION_ID     INT NOT NULL,

    CONSTRAINT PK_RESERVATION_EXPERIENCE
    PRIMARY KEY (RES_EXP_ID)
);
GO


/*==============================================================*/
/* INDEXES                                                      */
/*==============================================================*/

CREATE INDEX IDX_EXPERIENCE_CONCIERGE
ON EXPERIENCE(CONCIERGE_ID);
GO

CREATE INDEX IDX_SUITE_HOTEL
ON SUITE(HOTEL_ID);
GO

CREATE INDEX IDX_RESERVATION_GUEST
ON RESERVATION(GUEST_ID);
GO

CREATE INDEX IDX_RESERVATION_SUITE
ON RESERVATION(SUITE_ID);
GO

CREATE INDEX IDX_RES_EXP_EXPERIENCE
ON RESERVATION_EXPERIENCE(EXPERIENCE_ID);
GO

CREATE INDEX IDX_RES_EXP_RESERVATION
ON RESERVATION_EXPERIENCE(RESERVATION_ID);
GO


/*==============================================================*/
/* FOREIGN KEYS                                                 */
/*==============================================================*/

ALTER TABLE EXPERIENCE
ADD CONSTRAINT FK_EXPERIEN_DOES_CONCIERG
FOREIGN KEY (CONCIERGE_ID)
REFERENCES CONCIERGE(CONCIERGE_ID);
GO


ALTER TABLE SUITE
ADD CONSTRAINT FK_SUITE_HAS_HOTEL
FOREIGN KEY (HOTEL_ID)
REFERENCES HOTEL(HOTEL_ID);
GO


ALTER TABLE RESERVATION
ADD CONSTRAINT FK_RESERVAT_BOOKS_GUEST
FOREIGN KEY (GUEST_ID)
REFERENCES GUEST(GUEST_ID);
GO


ALTER TABLE RESERVATION
ADD CONSTRAINT FK_RESERVAT_BOOK_SUITE
FOREIGN KEY (SUITE_ID)
REFERENCES SUITE(SUITE_ID);
GO


ALTER TABLE RESERVATION_EXPERIENCE
ADD CONSTRAINT FK_RESERVAT_CONTAINS_EXPERIEN
FOREIGN KEY (EXPERIENCE_ID)
REFERENCES EXPERIENCE(EXPERIENCE_ID);
GO


ALTER TABLE RESERVATION_EXPERIENCE
ADD CONSTRAINT FK_RESERVAT_CREATES_RESERVAT
FOREIGN KEY (RESERVATION_ID)
REFERENCES RESERVATION(RESERVATION_ID);
GO