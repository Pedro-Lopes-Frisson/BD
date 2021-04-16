create schema FlightBooking;

ALTER TABLE  FlightBooking.Airplane                           ADD CONSTRAINT          airplaneAirplane_Type
ALTER TABLE  FlightBooking.Seat                               ADD CONSTRAINT          seat_legNo
ALTER TABLE  FlightBooking.Seat                               ADD CONSTRAINT          seat_flightNumber
ALTER TABLE  FlightBooking.Seat                               ADD CONSTRAINT          seat_legInstance_date
ALTER TABLE  FlightBooking.Flight_Legs                        ADD CONSTRAINT          leg_FlighNumber
ALTER TABLE  FlightBooking.Flight_Legs                        ADD CONSTRAINT          leg_depCode
ALTER TABLE  FlightBooking.Flight_Legs                        ADD CONSTRAINT          leg_arrCode
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_flightLeg
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_depAirport
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_arrAiport
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_airplane
ALTER TABLE  FlightBooking.Fare                               ADD CONSTRAINT          fare_fligtNumber
ALTER TABLE  FlightBooking.Can_Land                           ADD CONSTRAINT          canLand_code
ALTER TABLE  FlightBooking.Can_Land                           ADD CONSTRAINT          canLand_Type



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
primary key (Airport_code),

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
 Seat_no                                                int                               not null,
 leg_instance_date                                      date                              not null,    -- foreign  leg instance
 flight_leg_leg_no                                      int                               not null,    -- foreign leg_instance
 flight_number                                          int                              not null,    -- foreign flight
 --Airplane_id                                            int                               not null,    -- foreign Airplane
 Customer_name                                          varchar(20)                       not null,
 CPhone                                                 char(9)                           not null,
primary key (Seat_no, leg_instance_date,   flight_leg_leg_no ,  flight_number),

);


CREATE TABLE FlightBooking.Can_Land(
 Type_Name                                            varchar(30)                                                                     not null, -- foreign Airplane_Type
  Ariport_code                                        varchar(12)                                                                     not null, --foreigh Airport
  primary key ( Type_name, Airport_code),
)
CREATE TABLE FlightBooking.LEG_INSTANCE(
 leg_date                                                     Date                              not null,     -- foreign   leg instance
 leg_no                                                       int                               not null,     -- foreign len instance
 No_of_avail_seats                                            int                               not null,
 flight_number                                                int                               not null,    -- foreign flight number
 depart_airport_code                                          char(12)                          not null,
 arrive_airport_code                                          char(12)                          not null,
 airplane_id                                                  int                               not null,
 depart_time                                                  Date                              not null,
 Arrive_time                                                  Date                              not null,
primary key (leg_date, leg_no, flight_number),

);


CREATE TABLE FlightBooking.Fare(
 code                                               int                               not null,
 flight_number                                      int                               not null,
 Restrictions                                       varchar(12)                               not null,
 amount                                             int                               not null,
 flight_number                                      int                               not null,
primary key (code, flight_number),

);


CREATE TABLE FlightBooking.Flight(
  flight_number                                    int                                   not null,
  airline                                      varchar(12)                               not null,
  weekdays                                      int                                     not null,
primary key (flight_number),

);


CREATE TABLE FlightBooking.Flight_Legs(
  Leg_no                                      int                               not null,
  flight_number                                 int                               not null,
 dep_airport_code                                      char(12)                               not null,
 arr_airport_code                                      char(12)                               not null,
 sch_dep                                      Date                               not null,
 sch_Arr                                      Date                               not null,

primary key ( Leg_no, flight_number),

);

ALTER TABLE  FlightBooking.Airplane                           ADD CONSTRAINT          airplaneAirplane_Type           FOREIGN KEY   (Airplane_Type_name)             REFERENCES         FlightBooking.Airplane_Type(Type_name);
ALTER TABLE  FlightBooking.Seat                               ADD CONSTRAINT          seat_legNo                      FOREIGN KEY   (flight_leg_leg_no)              REFERENCES         FlightBooking.Flight_Legs(Leg_no);
ALTER TABLE  FlightBooking.Seat                               ADD CONSTRAINT          seat_flightNumber               FOREIGN KEY   (flight_number)                  REFERENCES         FlightBooking.Flight(flight_number);
ALTER TABLE  FlightBooking.Seat                               ADD CONSTRAINT          seat_legInstance_date           FOREIGN KEY   (leg_instance_date)              REFERENCES         FlightBooking.LEG_INSTANCE(leg_date);
ALTER TABLE  FlightBooking.Flight_Legs                        ADD CONSTRAINT          leg_FlighNumber                 FOREIGN KEY   ( flight_number)                 REFERENCES         FlightBooking.Flight(flight_number);
ALTER TABLE  FlightBooking.Flight_Legs                        ADD CONSTRAINT          leg_depCode                     FOREIGN KEY   (dep_airport_code)               REFERENCES         FlightBooking.Airport(code);
ALTER TABLE  FlightBooking.Flight_Legs                        ADD CONSTRAINT          leg_arrCode                     FOREIGN KEY   (arr_airport_code )              REFERENCES         FlightBooking.Airport(code);
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_flightLeg                   FOREIGN KEY   (flight_number   )               REFERENCES         FlightBooking.Flight_Legs(flight_number);
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_depAirport                  FOREIGN KEY   (depart_airport_code )           REFERENCES          FlightBooking.Airport(code);
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_arrAiport                   FOREIGN KEY   (arrive_airport_code )           REFERENCES          FlightBooking.Airport(code);
ALTER TABLE  FlightBooking.LEG_INSTANCE                       ADD CONSTRAINT          LEG_airplane                    FOREIGN KEY   (airplane_id         )           REFERENCES          FlightBooking.Airplane(id);
ALTER TABLE  FlightBooking.Fare                               ADD CONSTRAINT          fare_fligtNumber                FOREIGN KEY   (flight_number )                 REFERENCES          FlightBooking.Flight(flight_number);
ALTER TABLE  FlightBooking.Can_Land                           ADD CONSTRAINT          canLand_code                    FOREIGN KEY   (airport_code)                   REFERENCES          FlightBooking.Airport(code);
ALTER TABLE  FlightBooking.Can_Land                           ADD CONSTRAINT          canLand_Type                    FOREIGN KEY   ( Type_name )                    REFERENCES          FlightBooking.Airplane_Type(Type_name);
