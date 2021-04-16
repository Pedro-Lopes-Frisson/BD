create schema FlightBooking;





ALTER TABLE   FlightBooking.Airplane                         DROP   CONSTRAINT       airplaneAirplaneType
ALTER TABLE   FlightBooking.Seat                    DROP   CONSTRAINT       seatAirplane
ALTER TABLE   FlightBooking.Seat                    DROP   CONSTRAINT       seatCustomer
ALTER TABLE   FlightBooking.Seat                    DROP   CONSTRAINT       CustomerPhone
ALTER TABLE   FlightBooking.LEG_INSTANCE                    DROP   CONSTRAINT
ALTER TABLE   FlightBooking.<>                    DROP   CONSTRAINT       <>
ALTER TABLE   FlightBooking.<>                    DROP   CONSTRAINT       <>
ALTER TABLE   FlightBooking.<>                    DROP   CONSTRAINT       <>
ALTER TABLE   FlightBooking.<>                    DROP   CONSTRAINT       <>
ALTER TABLE   FlightBooking.<>                    DROP   CONSTRAINT       <>
ALTER TABLE   FlightBooking.<>                    DROP   CONSTRAINT       <>



DROP TABLE FlightBooking.Airport
DROP TABLE FlightBooking.Airplane_Type
DROP TABLE FlightBooking.Airplane
DROP TABLE FlightBooking.Seat
DROP TABLE FlightBooking.Can_Land
DROP TABLE FlightBooking.LEG_INSTANCE
DROP TABLE FlightBooking.Fare
DROP TABLE FlightBooking.Flight
DROP TABLE FlightBooking.Flight_Legs



CREATE TABLE FlightBooking.Airport(
 Airport_code                                      char(12)                               not null,
 City                                      varchar(20)                               not null,
 State                                      varchar(10)                               not null,
 Name                                      varchar(30)                               not null,
primary key (Airplane_Type),

);


CREATE TABLE FlightBooking.Airplane_Type(
 Type_name                                      varchar(20)                               not null,
 Company                                      varchar(20)                               not null,
 Max_seats                                      varchar(20)                               not null,
primary key (Type_Name),

);


CREATE TABLE FlightBooking.Airplane(
 Airplane_id                                            int                               not null,
 Total_no_of_seats                                      int                               not null,
 Airplane_Type_name                                      varchar(20)                               not null,
primary key (Airplane_id),

);


CREATE TABLE FlightBooking.Seat(
 Seat_no                                      int                               not null,
 leg_instance_date                                      date                               not null,
 flight_leg_leg_no                                      int                               not null,
flight_number                                           int                               not null,
 Airplane_id                                            int                               not null,
 Customer_name                                          varchar(20)                              not null,
 CPhone                                                 char(9)                               not null,
primary key (Seat_no, leg_instance_date,   flight_leg-leg_no ,  flight_number),

);


CREATE TABLE FlightBooking.Can_Land(
 Type_Name                                            varchar(30)                                                                     not null,
Ariport_code
                                      <>                               not null,
)
CREATE TABLE FlightBooking.LEG_INSTANCE(
 a_date                                                     Date                                      <>                               not null,
 flight_leg-leg_no
                                      <>                               not null,
 flight_number                                      <>                               not null,
 No_of_avail_seats                                      <>                               not null,
 depart_time                                      <>                               not null,
 Arrive_time                                      <>                               not null,
primary key (),

);


CREATE TABLE FlightBooking.Fare(
 code                                      <>                               not null,
 flight_number                                      <>                               not null,
 Restrictions                                      <>                               not null,
 amount                                      <>                               not null,
 code                                      <>                               not null,
 flight_number                                      <>                               not null,
primary key (),

);


CREATE TABLE FlightBooking.Flight(
 Number                                      <>                               not null,
 airline                                      <>                               not null,

        w                              <>                               not nulleekdays
                                      <>                               not null,
primary key (),

);


CREATE TABLE FlightBooking.Flight_Legs(
 Leg_no                                      <>                               not null,
flight_number
                                      <>                               not null,
 airport_code                                      <>                               not null,
 airport_code                                      <>                               not null,
 sch_dep                                      <>                               not null,
 sch_Arr                                      <>                               not null,
 sch_dep                                      <>                               not null,
 sch_Arr                                      <>                               not null,

                                      <>                               not null,
primary key (),

);


ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (Airplane_Type_name)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (Airplane_id)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (Customer_name)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (CPhone)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (depart_time)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (arrive_time)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (flight_number)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (flight_number)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (airport_code)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (Type_name)                REFERENCES          FlightBooking.<>();
ALTER TABLE   FlightBooking.<>                    ADD   CONSTRAINT       <>        foreign key (Airport_code)                REFERENCES          FlightBooking.<>();
