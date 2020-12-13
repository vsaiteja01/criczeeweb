create database project;

use project;

create table MumbaiIndians(PlayerId int not null identity,Player nvarchar(50),PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder'))); 

insert into MumbaiIndians(Player,PlayerRole,Price)values('Rohit Sharma','Batsman','15 crore'),
                                                        ('Anmolpreet Singh','Batsman','80 lakhs'),
														('Ankul Roy ','Batsman','20 lakhs'),
														('Sherfane Rutherford','Batsman','2 crore'),
														('Suryakumar Yadav','Batsman','3.20 crore'),
														('Chris Lynn','Batsman','2 crore'),
														('Saurabh Tiwary','Batsman','50 lakhs'),
                                                        ('Aditya Tare','Wicket Keeper','20 lakhs'),
                                                        ('Ishan Kishan','Wicket Keeper','6.20 crore'),
                                                        ('Quinton de Kock ','Wicket Keeper','2.80 crore'),
                                                        ('Hardik Pandya',	'All-Rounder','	11 crore'),
                                                        ('Kieron Pollard','All-Rounder','5.40 crore'),
                                                        ('Krunal Pandya','All-Rounder','8.80 crore'),
                                                        ('Rahul Chahar','All-Rounder','1.90 crore'),
                                                        ('Digvijay Deshmukh','All-Rounder','20 lakhs'),
                                                        ('Prince Balwant Rai Singh','All-Rounder','20 lakhs'),
                                                        ('Dhawal Kulkarni','Bowler','75 lakhs'),
                                                        ('Jasprit Bumrah','Bowler','7 crore'),
                                                        ('Jayant Yadav','Bowler','50 lakhs'),
                                                        ('James Pattinson','Bowler','1 crore'),
                                                        ('Mitchell McClenaghan','Bowler','1 crore'),
                                                        ('Trent Boult','Bowler','3.20 crore'),
                                                        ('Nathan Coulter-Nile','Bowler','8 crore'),
                                                        ('Mohsin Khan','Bowler','20 lakhs');
--displaying all Players from MumbaiIndians

select * from MumbaiIndians;

create table RoyalChallengersBanglore(PlayerId int not null identity,Player nvarchar(50),PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));

insert into RoyalChallengersBanglore(Player,PlayerRole,Price)values('Virat Kohli','Batsman','17 crore'),                                                            
                                                                   ('AB de Villiers','Batsman','11 crore'),
                                                                   ('Devdutt Padikkal','Batsman','20 lakhs'),
                                                                   ('Gurkeerat Singh','Batsman','50 lakhs'),
                                                                   ('Aaron Finch','Batsman','4.40 crore'),
                                                                   ('Shahbaz Ahamad','Wicket Keeper','20 lakhs'),
                                                                   ('Joshua Philippe','Wicket Keeper','20 lakhs'),
                                                                   ('Parthiv Patel','Wicket Keeper','1.70 crore'),
                                                                   ('Pawan Negi','All-Rounder','1 crore'),
                                                                   ('Shivam Dube','All-Rounder','5 crore'),
                                                                   ('Moeen Ali','All-Rounder','1.70 crore'),
                                                                   ('Isuru Udana','All-Rounder','50 lakhs'),
                                                                   ('Pavan Deshpande','All-Rounder','20 lakhs'),
                                                                   ('Christopher Morris','All-Rounder','10 crore'),
                                                                   ('Adam Zampa','Bowler','1.5 crore'),
                                                                   ('Dale Steyn','Bowler','2 crore'),
                                                                   ('Mohammed Siraj','Bowler','2.60 crore'),
                                                                   ('Navdeep Saini','Bowler','3 crore'),
                                                                   ('Umesh Yadav','Bowler','4.20 crore'),
                                                                   ('Washington Sundar','Bowler','3.20 crore'),
                                                                   ('Yuzvendra Chahal','Bowler','6 crore');

--displaying all Players from RoyalChallengersBanglore

select * from RoyalChallengersBanglore;

create table ChennaiSuperKings(PlayerId int not null identity,Player nvarchar(50) ,PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));

insert into ChennaiSuperKings(Player,PlayerRole,Price)values('Ambati Rayudu','Batsman','2.20 crore'),
                                                            ('Monu Kumar','Batsman','20 lakhs'),
                                                            ('Murali Vijay','Batsman','2 crore'),
                                                            ('Ruturaj Gaikwad','Batsman','20 lakhs'),
                                                            ('MS Dhoni','Wicket Keeper','15 crore'),
                                                            ('Jagadeesan Narayan','Wicket Keeper','20 lakhs'),
                                                            ('K M Asif','All-Rounder','40 lakhs'),
                                                            ('Dwayne Bravo','All-Rounder','6.40 crore'),
                                                            ('Faf du Plessis','All-Rounder','1.60 crore'),
                                                            ('Karn Sharma','All-Rounder','5 crore'),
                                                            ('Kedar Jadhav','All-Rounder','7.80 crore'),
                                                            ('Ravindra jadeja','All-Rounder','7 crore'),
                                                            ('Shane Watson','All-Rounder','4 crore'),
                                                            ('Sam Curran','All-Rounder','5.50 crore'),
                                                            ('Deepak Chahar','Bowler','80 lakhs'),
                                                            ('Imran Tahir','Bowler','1 crore'),
                                                            ('Lungisani Ngidi','Bowler','50 lakhs'),
                                                            ('Mitchell Santner','Bowler','50 lakhs'),
                                                            ('Shardul Thakur','Bowler','2.60 crore'),
                                                            ('Piyush Chawla','Bowler','6.75 crore'),
                                                            ('Josh Hazlewood','Bowler','2 crore'),
                                                            ('R. Sai Kishore','Bowler','20 lakhs');

--displaying all Players from ChennaiSuperKings

select * from ChennaiSuperKings;

create table DelhiCapitals(PlayerId int not null identity,Player nvarchar(50) ,PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));

insert into DelhiCapitals(Player,PlayerRole,Price)  values  ('Shreyas Iyer','Batsman','7 crore'),
                                                            ('Ajinkya Rahane','Batsman','5.25 crore'),
                                                            ('Keemo Paul ','Batsman','50 lakhs'),
                                                            ('Prithvi Shaw','Batsman','1.20 crore'),
                                                            ('Shikhar Dhawan','Batsman','5.20 crore'),
                                                            ('Shimron Hetmyer','Batsman','7.75 crore'),
                                                            ('Rishabh Pant','Wicket Keeper','15 crore'),
                                                            ('Alex Carey','Wicket Keeper','2.40 crore'),
                                                            ('Marcus Stoinis','All-Rounder','4.80 crore'),
                                                            ('Lalith Yadav','All-Rounder','20 lakhs'),
                                                            ('Daniel Sams','Bowler',''),
                                                            ('Anrich Nortje','Bowler',''),
                                                            ('Avesh Khan','Bowler','70 lakhs'),
                                                            ('Ravichandran Ashwin','Bowler','7.60 crore'),
                                                            ('Sandeep Lamichhane','Bowler','20 lakhs'),
                                                            ('Axar Patel','Bowler','5 crore'),
                                                            ('Harshal Patel','Bowler','20 lakhs'),
                                                            ('Ishant Sharma','Bowler','1.10 crore'),
                                                            ('Kagiso Rabada','Bowler','4.20 crore'),
                                                            ('Mohit Sharma','Bowler','50 lakhs'),
                                                            ('Tushar Deshpande','Bowler','20 lakhs'),
                                                            ('Amit Mishra','Bowler','4 crore');

--displaying all Players from  DelhiCapitals

select * from DelhiCapitals;

create table RajasthanRoyals(PlayerId int not null identity,Player nvarchar(50),PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));

insert into RajasthanRoyals(Player,PlayerRole,Price)  values  ('Riyan Parag','Batsman','20 lakhs'),
                                                              ('Shashank Singh','Batsman','30 lakhs'),
                                                              ('Steve Smith','Batsman','12.50 crore'),
                                                              ('Robin Uthappa','Batsman','3 crore'),
                                                              ('David Miller','Batsman','75 lakhs'),
                                                              ('Manan Vohra','Batsman','20 lakhs'),
                                                              ('Jos Butler','Wicket Keeper','4.40 crore'),
                                                              ('Sanju Samson','Wicket Keeper','8 crore'),
                                                              ('Anuj Rawat','Wicket Keeper','80 lakhs'),
                                                              ('Ben Stokes','All-Rounder','12.50 crore'),
                                                              ('Mahipal Lomror','All-Rounder','20 lakhs'),
                                                              ('Shreyas Gopal','All-Rounder','20 lakhs'),
                                                              ('Yashasvi Jaiswal','All-Rounder','2.40 crore'),
                                                              ('Tom Curran','All-Rounder','1 crore'),
                                                              ('Ankit Rajpoot','Bowler','3 crore'),
                                                              ('Jofra Archer','Bowler','7.20 crore'),
                                                              ('Mayank Markande','Bowler','2 crore'),
                                                              ('Rahul Tewatia','Bowler','3 crore'),
                                                              ('Varun Aaron','Bowler','2.40 crore'),
                                                              ('Jaydev Unadkat','Bowler','3 crore'),
                                                              ('Kartik Tyagi','Bowler','1.30 crore'),
                                                              ('Andrew Tye','Bowler','1 crore'),
                                                              ('Oshane Thomas','Bowler','50 lakhs'),
                                                              ('Anirudha Ashok Joshi','All-Rounder','20 lakhs'),
                                                              ('Akash Singh','Bowler','20 lakhs');

--displaying all Players from  RajasthanRoyals

select * from RajasthanRoyals;

create table SunRisesHyderabad(PlayerId int not null identity,Player nvarchar(50),PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));


insert into SunRisesHyderabad(Player,PlayerRole,Price)  values  ('Kane Williamson','Batsman','	3 crore'),
                                                                ('Abhishek Sharma','Batsman','55 lakhs'),
                                                                ('David Warner','Batsman','12.50 crore'),
                                                                ('Manish Pandey','Batsman','11 crore'),
                                                                ('Priyam Garg','Batsman','1.90 crore'),
                                                                ('Virat Singh','Batsman','1.90 crore'),
                                                                ('Jonny Bairstow','Wicket Keeper','2.20 crore'),
                                                                ('Shreevats Goswami','Wicket Keeper','1 crore'),
                                                                ('Wridhhiman Saha','Wicket Keeper','1.20 crore'),
                                                                ('Vijay Shankar','All-Rounder','3.20 crore'),
                                                                ('Mitchell Marsh','All-Rounder','2 crore'),
                                                                ('Mohammad Nabi','All-Rounder','1 crore'),
                                                                ('Fabian Allen','All-Rounder','50 lakhs'),
                                                                ('Sandeep Bavanaka','All-Rounder','20 lakhs'),
                                                                ('Sanjay Yadav','All-Rounder','20 lakhs'),
                                                                ('Abdul Samad','All-Rounder','20 lakhs'),
                                                                ('Basil Thampi','Bowler','95 lakhs'),
                                                                ('Bhuvneshwar Kumar','Bowler','8.50 crore'),
                                                                ('Billy Stanlake','Bowler','50 lakhs'),
                                                                ('Rashid Khan','Bowler','9 crore'),
                                                                ('Sandeep Sharma ','Bowler'	,'3 crore'),
                                                                ('Shahbaz Nadeem','Bowler','3.20 crore'),
                                                                ('Siddarth Kaul','Bowler','3.80 crore'),
                                                                ('Syed Khaleel Ahmed ','Bowler','3 crore'),
                                                                ('T Natarajan','Bowler','40 lakhs');

--displaying all Players from SunRisesHyderabad

select * from SunRisesHyderabad;

create table KolkataKnightRiders(PlayerId int not null identity,Player nvarchar(50),PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));

insert into KolkataKnightRiders(Player,PlayerRole,Price)  values('Harry Gurney','Batsman','75 lakhs'),
                                                                ('Nitish Rana','Batsman','3.40 crore'),
                                                                ('Rinku Singh','Batsman','80 lakhs'),
                                                                ('Shubham Gill','Batsman','1.80 crore'),
                                                                ('Siddhesh Lad','Batsman','20 lakhs'),
                                                                ('Eoin Morgan','Batsman','5.25 crore'),
                                                                ('Tom Banton','Batsman','1 crore'),
                                                                ('Rahul Tripathi','Batsman','60 lakhs'),
                                                                ('Dinesh Karthik','Wicket Keeper','7.40 crore'),
                                                                ('Nikhil Shankar Naik','Wicket Keeper','20 lakhs'),
                                                                ('Sunil Narine','All-Rounder','12.50 crore'),
                                                                ('Pat Cummins','All-Rounder','15.5 crore'),
                                                                ('Shivam Mavi','All-Rounder','3 crore'),
                                                                ('Chris Green','All-Rounder','20 lakhs'),
                                                                ('Andre Russell','All-Rounder','8.50 crore'),
                                                                ('Lockie Ferguson','All-Rounder','1.60 crore'),
															    ('Prasidh Krishna','Bowler','20 lakhs'),
                                                                ('Kuldeep Yadav','Bowler','5.80 crore'),
                                                                ('Sandeep Warrier','Bowler','20 lakhs'),
                                                                ('M Siddharth','Bowler','20 lakhs'),
                                                                ('Varun Chakaravarthy','Bowler','4 crore');

--displaying all Players from KolkataKnightRiders

select * from KolkataKnightRiders;

create table KingsXIPunjab(PlayerId int not null identity,Player nvarchar(50),PlayerRole nvarchar(50) ,Price nvarchar(50),primary key(Player),check(PlayerRole in ('Batsman','Bowler','Wicket Keeper','All-Rounder')));


insert into KingsXIPunjab(Player,PlayerRole,Price) values('Karun Nair ','Batsman','5.60 crore'),
                                                         ('Arshdeep Singh','Batsman','20 lakhs'),
                                                         ('Chris Gayle','Batsman','2 crore'),
                                                         ('Darshan Nalkande','Batsman','30 lakhs'),
                                                         ('Gowtham Krishnappa','Batsman','6.20 crore'),
                                                         ('Hardus Viljoen','Batsman','75 lakhs'),
                                                         ('Harpreet Brar','Batsman','20 lakhs'),
                                                         ('Mayank Agarwal','Batsman','1 crore'),
                                                         ('Nicholas Pooran ','Batsman','4.20 crore'),
                                                         ('Sarfaraz Khan','Batsman','25 lakhs'),
                                                         ('Simran Singh','Wicket Keeper','55 lakhs'),
                                                         ('KL Rahul (R)','Wicket Keeper','11 crore'),
                                                         ('Mandeep Singh','All-Rounder','1.40 crore'),
                                                         ('Glenn Maxwell','All-Rounder','10.75 crore'),
                                                         ('Chris Jordan','All-Rounder','3 crore'),
                                                         ('Deepak Hooda','All-Rounder','50 lakhs'),
                                                         ('James Neesham','All-Rounder','50 lakhs'),
                                                         ('Tajinder Singh Dhillon','All-Rounder','20 lakhs'),
                                                         ('Ishan Porel','Bowler','20 lakhs'),
                                                         ('Jagadeesha Suchith','Bowler','20 lakhs'),
                                                         ('Mohammad Shami','Bowler','4.80 crore'),
                                                         ('Ravi Bishnoi','Bowler','2 crore'),
                                                         ('Sheldon Cottrell','Bowler','8.50 crore'),
                                                         ('Murugan Ashwin','Bowler','20 lakhs'),
                                                         ('Mujeeb Ur Rahman','Bowler','4 crore');


--displaying all Players from KingsXIPunjab.

select * from KingsXIPunjab;

create table TopBatsmens(PlayerId int not null identity,Player nvarchar(50) primary key,Innings int not null,Runs int not null );

insert into TopBatsmens(Player,Innings,Runs) values ('KL Rahul',14,670),('Shikhar Dhawan',17,618),('David Warner',16,548),('Shreyas Iyer',17,519),('Ishan Kishan',13,516);

--displaying top batsmens according to most runs scored.

select * from TopBatsmens order by Runs desc; 

create table TopBowlers(PlayerId int not null identity,Player nvarchar(50) primary key ,Matches int not null,Wickets int not null );


insert into TopBowlers(Player,Matches,Wickets) values ('Kagiso Rabada',17,30),('Jasprit Bumrah',15,27),('Trent Boult',15,25),('Anrich Nortje',16,22),('Yuzvendra Chahal',15,21);

--displaying top bowlers according to most wickets taken.

select * from TopBowlers order by Wickets desc; 

create table TopFielders(PlayerId int not null identity,Player nvarchar(50) primary key,Matches int not null,Catches int not null );

insert into TopFielders(Player,Matches,Catches) values ('Faf du Plessis',13,12),('Kieron Pollard',16,8),('Devdutt Padikkal',15,8),('David Warner',16,12),('Rahul Tewatia',14,9);

--displaying top fielders according to most catches taken.

select * from TopFielders order by Catches desc;

create table PointsTable(TeamId int not null identity,Teams nvarchar(50) primary key,Matches int,Won int,Lost int,Tied int,Points int,NRR nvarchar(50),NRRPosition int);

insert into PointsTable(Teams,Matches,Won,Lost,Tied,Points,NRR,NRRPosition) values ('Mumbai Indians',14,9,5,0,18,'+1.107',1),
                                                                       ('Delhi Capitals',11,7,4,0,14,'+0.434',2),	
                                                                       ('Royal Challengers Bangalore',11,7,4,0,14,'+0.092',3),	
                                                                       ('Kings XI Punjab',12,6,6,0,12,'-0.049',5),	
                                                                       ('Kolkata Knight Riders',12,6,6,0,12,'-0.479',6),	
                                                                       ('Rajasthan Royals',12,5,7,0,10,'-0.505',7),	
                                                                       ('Sunrisers Hyderabad',11,4,7,0,8,'+0.029',4),	
                                                                       ('Chennai Super Kings',12,4,8,0,8,'-0.602',8);	

--displaying pointstable.

select * from PointsTable order by NRRPosition,Won desc;

select * from PointsTable;









