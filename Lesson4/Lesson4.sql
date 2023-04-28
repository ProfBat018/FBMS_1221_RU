-- create database Academy;
--

use Academy;

create table Person (
    [Id] int identity(1,1) primary key,
    [Name] nvarchar(50) not null check (len([Name]) >= 2),
    [Surname] nvarchar(50) not null check (len([Surname]) >= 3),
    [Age] int not null check ([Age] >= 15 and [Age] <= 65),
    [Email] nvarchar(50) not null unique check ([Email] like '%_@__%.__%')
);


create table Teachers(
  [Id] int identity(1,1) primary key,
  [PersonId] int not null foreign key references Person([Id]),
  [Salary] smallmoney not null check ([Salary] >= 300)
);


create table Faculty(
  [Id] int identity(1,1) primary key,
  [Name] nvarchar(50) not null check (len([Name]) >= 5)
);

create table Groups(
    [Id] int identity(1,1) primary key,
    [Name] nvarchar(50) not null check (len([Name]) >= 2),
    [Course] int not null check ([Course] >= 1 and [Course] <= 4) default 1,
    [FacultyId] int not null foreign key references Faculty([Id])
);


create table Students(
    [Id] int identity(1,1) primary key,
    [PersonId] int not null foreign key references Person([Id]),
    [GPA] decimal(3,2) not null check ([GPA] >= 0 and [GPA] <= 5),
    [GroupId] int not null foreign key references Groups([Id])
);


create table GroupTeachers(
    [Id] int identity(1,1) primary key,
    [GroupId] int not null foreign key references Groups([Id]),
    [TeacherId] int not null foreign key references Teachers([Id]),
    [IsCurator] bit not null default 0
);
--
select * from Person;

-- insert into Person (Name, Surname, Age, Email) values ('Wileen', 'McLaine', 56, 'wmclaine0@yahoo.co.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Nev', 'Breyt', 23, 'nbreyt1@vkontakte.ru');
-- insert into Person (Name, Surname, Age, Email) values ('Audry', 'Felder', 56, 'afelder2@etsy.com');
-- insert into Person (Name, Surname, Age, Email) values ('Patty', 'Binion', 44, 'pbinion3@ucsd.edu');
-- insert into Person (Name, Surname, Age, Email) values ('Moises', 'Worvill', 25, 'mworvill4@dell.com');
-- insert into Person (Name, Surname, Age, Email) values ('Crissie', 'Jonas', 15, 'cjonas5@oracle.com');
-- insert into Person (Name, Surname, Age, Email) values ('Gavra', 'Waulker', 57, 'gwaulker6@hugedomains.com');
-- insert into Person (Name, Surname, Age, Email) values ('Dierdre', 'Aleksich', 34, 'daleksich7@washington.edu');
-- insert into Person (Name, Surname, Age, Email) values ('Karissa', 'Mazillius', 45, 'kmazillius8@surveymonkey.com');
-- insert into Person (Name, Surname, Age, Email) values ('Aridatha', 'Edes', 27, 'aedes9@nbcnews.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ivor', 'Ragat', 30, 'iragata@youtu.be');
-- insert into Person (Name, Surname, Age, Email) values ('Emmet', 'Aberchirder', 42, 'eaberchirderb@blogtalkradio.com');
-- insert into Person (Name, Surname, Age, Email) values ('Goldia', 'Yair', 28, 'gyairc@timesonline.co.uk');
-- insert into Person (Name, Surname, Age, Email) values ('Rae', 'Swatland', 51, 'rswatlandd@sakura.ne.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Ian', 'Postance', 34, 'ipostancee@desdev.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Douglass', 'Buckler', 18, 'dbucklerf@ning.com');
-- insert into Person (Name, Surname, Age, Email) values ('Yardley', 'Morin', 19, 'ymoring@fema.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Caresse', 'Carefull', 15, 'ccarefullh@fda.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Caryl', 'Ingre', 64, 'cingrei@ustream.tv');
-- insert into Person (Name, Surname, Age, Email) values ('Flin', 'MacFall', 20, 'fmacfallj@yolasite.com');
-- insert into Person (Name, Surname, Age, Email) values ('Morey', 'Orys', 47, 'morysk@loc.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Lilian', 'Guilloton', 49, 'lguillotonl@deliciousdays.com');
-- insert into Person (Name, Surname, Age, Email) values ('Sax', 'Arpur', 20, 'sarpurm@slideshare.net');
-- insert into Person (Name, Surname, Age, Email) values ('Carmine', 'Guidone', 22, 'cguidonen@noaa.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Loni', 'Twist', 43, 'ltwisto@microsoft.com');
-- insert into Person (Name, Surname, Age, Email) values ('Isiahi', 'Asel', 39, 'iaselp@dailymotion.com');
-- insert into Person (Name, Surname, Age, Email) values ('Vitoria', 'Gipps', 32, 'vgippsq@github.io');
-- insert into Person (Name, Surname, Age, Email) values ('Allyson', 'Tyreman', 21, 'atyremanr@plala.or.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Blanch', 'Fierro', 25, 'bfierros@yellowbook.com');
-- insert into Person (Name, Surname, Age, Email) values ('Laraine', 'Cowope', 18, 'lcowopet@moonfruit.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ally', 'Clamp', 20, 'aclampu@hugedomains.com');
-- insert into Person (Name, Surname, Age, Email) values ('Mignon', 'Readwin', 57, 'mreadwinv@edublogs.org');
-- insert into Person (Name, Surname, Age, Email) values ('Bertrando', 'Prest', 23, 'bprestw@miitbeian.gov.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Sophia', 'Pillinger', 29, 'spillingerx@tmall.com');
-- insert into Person (Name, Surname, Age, Email) values ('Devy', 'Auguste', 27, 'daugustey@amazon.com');
-- insert into Person (Name, Surname, Age, Email) values ('Luca', 'Baress', 57, 'lbaressz@unblog.fr');
-- insert into Person (Name, Surname, Age, Email) values ('Broderic', 'Mellhuish', 50, 'bmellhuish10@sogou.com');
-- insert into Person (Name, Surname, Age, Email) values ('Patti', 'Zappel', 15, 'pzappel11@narod.ru');
-- insert into Person (Name, Surname, Age, Email) values ('Ganny', 'Vise', 18, 'gvise12@apache.org');
-- insert into Person (Name, Surname, Age, Email) values ('Farrell', 'Rimmer', 25, 'frimmer13@msu.edu');
-- insert into Person (Name, Surname, Age, Email) values ('Brynn', 'Wroughton', 22, 'bwroughton14@opensource.org');
-- insert into Person (Name, Surname, Age, Email) values ('Clarence', 'Hazlehurst', 18, 'chazlehurst15@about.me');
-- insert into Person (Name, Surname, Age, Email) values ('Quint', 'Wallicker', 26, 'qwallicker16@nhs.uk');
-- insert into Person (Name, Surname, Age, Email) values ('Jobye', 'Minihan', 29, 'jminihan17@answers.com');
-- insert into Person (Name, Surname, Age, Email) values ('Allyn', 'Chazerand', 55, 'achazerand18@weibo.com');
-- insert into Person (Name, Surname, Age, Email) values ('Shayla', 'Brugmann', 36, 'sbrugmann19@miitbeian.gov.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Daphene', 'Dulany', 47, 'ddulany1a@deviantart.com');
-- insert into Person (Name, Surname, Age, Email) values ('Marv', 'Soans', 50, 'msoans1b@networkadvertising.org');
-- insert into Person (Name, Surname, Age, Email) values ('Heidi', 'Francello', 46, 'hfrancello1d@msu.edu');
-- insert into Person (Name, Surname, Age, Email) values ('Kelley', 'Artois', 35, 'kartois1e@google.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Lindsey', 'Benardeau', 33, 'lbenardeau1f@mapy.cz');
-- insert into Person (Name, Surname, Age, Email) values ('Amara', 'Waistall', 28, 'awaistall1g@google.de');
-- insert into Person (Name, Surname, Age, Email) values ('Jonas', 'Huguenet', 45, 'jhuguenet1h@washingtonpost.com');
-- insert into Person (Name, Surname, Age, Email) values ('Chrissy', 'Caplen', 44, 'ccaplen1i@flickr.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ainslie', 'Klaessen', 29, 'aklaessen1j@google.com.hk');
-- insert into Person (Name, Surname, Age, Email) values ('Stanislaw', 'Kirkman', 58, 'skirkman1k@mail.ru');
-- insert into Person (Name, Surname, Age, Email) values ('Harry', 'Hardacre', 47, 'hhardacre1l@deviantart.com');
-- insert into Person (Name, Surname, Age, Email) values ('Maurice', 'Bodley', 61, 'mbodley1m@google.ru');
-- insert into Person (Name, Surname, Age, Email) values ('Pierson', 'Joannet', 15, 'pjoannet1n@eventbrite.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ameline', 'Malpass', 47, 'amalpass1o@altervista.org');
-- insert into Person (Name, Surname, Age, Email) values ('Mehetabel', 'Antonoyev', 22, 'mantonoyev1p@cbslocal.com');
-- insert into Person (Name, Surname, Age, Email) values ('Milt', 'Salisbury', 53, 'msalisbury1q@thetimes.co.uk');
-- insert into Person (Name, Surname, Age, Email) values ('Marya', 'Feasley', 40, 'mfeasley1r@pcworld.com');
-- insert into Person (Name, Surname, Age, Email) values ('Katerina', 'Swaby', 29, 'kswaby1s@istockphoto.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ivonne', 'Burtonshaw', 59, 'iburtonshaw1t@csmonitor.com');
-- insert into Person (Name, Surname, Age, Email) values ('Cayla', 'Tersay', 32, 'ctersay1u@weather.com');
-- insert into Person (Name, Surname, Age, Email) values ('Jillian', 'Linscott', 57, 'jlinscott1v@webs.com');
-- insert into Person (Name, Surname, Age, Email) values ('Pepe', 'Stiger', 58, 'pstiger1w@mail.ru');
-- insert into Person (Name, Surname, Age, Email) values ('Iver', 'Coughlan', 46, 'icoughlan1x@bloglovin.com');
-- insert into Person (Name, Surname, Age, Email) values ('Wilburt', 'Kew', 57, 'wkew1y@opera.com');
-- insert into Person (Name, Surname, Age, Email) values ('Iggy', 'Girardetti', 46, 'igirardetti1z@nasa.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Andriette', 'Laurenceau', 64, 'alaurenceau20@xing.com');
-- insert into Person (Name, Surname, Age, Email) values ('Curcio', 'Brassington', 48, 'cbrassington21@timesonline.co.uk');
-- insert into Person (Name, Surname, Age, Email) values ('Helaina', 'Riding', 45, 'hriding22@altervista.org');
-- insert into Person (Name, Surname, Age, Email) values ('Clerc', 'Daouze', 33, 'cdaouze23@elegantthemes.com');
-- insert into Person (Name, Surname, Age, Email) values ('Leontine', 'Zanettini', 54, 'lzanettini24@ebay.com');
-- insert into Person (Name, Surname, Age, Email) values ('Windham', 'Treanor', 16, 'wtreanor25@tumblr.com');
-- insert into Person (Name, Surname, Age, Email) values ('Johnette', 'Richichi', 54, 'jrichichi26@posterous.com');
-- insert into Person (Name, Surname, Age, Email) values ('Kermit', 'Schubart', 62, 'kschubart27@domainmarket.com');
-- insert into Person (Name, Surname, Age, Email) values ('Vin', 'Lodwick', 41, 'vlodwick28@npr.org');
-- insert into Person (Name, Surname, Age, Email) values ('Chuck', 'Babalola', 52, 'cbabalola29@ow.ly');
-- insert into Person (Name, Surname, Age, Email) values ('Burk', 'Hurnell', 15, 'bhurnell2a@netlog.com');
-- insert into Person (Name, Surname, Age, Email) values ('Cornelius', 'Cecere', 36, 'ccecere2b@hatena.ne.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Linnie', 'Brisseau', 35, 'lbrisseau2c@issuu.com');
-- insert into Person (Name, Surname, Age, Email) values ('Thomasina', 'Durbann', 27, 'tdurbann2d@time.com');
-- insert into Person (Name, Surname, Age, Email) values ('Arabel', 'Smorfit', 60, 'asmorfit2e@homestead.com');
-- insert into Person (Name, Surname, Age, Email) values ('Abbi', 'Jessopp', 50, 'ajessopp2f@myspace.com');
-- insert into Person (Name, Surname, Age, Email) values ('Westleigh', 'Brandreth', 18, 'wbrandreth2g@weibo.com');
-- insert into Person (Name, Surname, Age, Email) values ('Gilbertine', 'Guille', 56, 'gguille2h@gizmodo.com');
-- insert into Person (Name, Surname, Age, Email) values ('Leif', 'Sellens', 35, 'lsellens2i@deviantart.com');
-- insert into Person (Name, Surname, Age, Email) values ('Letisha', 'Brackenbury', 40, 'lbrackenbury2j@istockphoto.com');
-- insert into Person (Name, Surname, Age, Email) values ('Jackqueline', 'Rizon', 20, 'jrizon2k@canalblog.com');
-- insert into Person (Name, Surname, Age, Email) values ('Amie', 'Lissemore', 64, 'alissemore2l@adobe.com');
-- insert into Person (Name, Surname, Age, Email) values ('Elbertina', 'Dunkinson', 46, 'edunkinson2m@t.co');
-- insert into Person (Name, Surname, Age, Email) values ('Darsey', 'Hackelton', 41, 'dhackelton2n@npr.org');
-- insert into Person (Name, Surname, Age, Email) values ('Anthony', 'Jonin', 48, 'ajonin2o@printfriendly.com');
-- insert into Person (Name, Surname, Age, Email) values ('Raimundo', 'Perren', 17, 'rperren2p@ibm.com');
-- insert into Person (Name, Surname, Age, Email) values ('Lilli', 'Normabell', 26, 'lnormabell2q@japanpost.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Judith', 'Vanni', 54, 'jvanni2r@jugem.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Aleen', 'Ingley', 42, 'aingley2s@globo.com');
-- insert into Person (Name, Surname, Age, Email) values ('Aileen', 'Dantesia', 58, 'adantesia2t@amazon.com');
-- insert into Person (Name, Surname, Age, Email) values ('Bran', 'Lodewick', 33, 'blodewick2u@seattletimes.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ofelia', 'Stent', 21, 'ostent2v@meetup.com');
-- insert into Person (Name, Surname, Age, Email) values ('Klemens', 'Moring', 48, 'kmoring2w@sakura.ne.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Aloysius', 'Scarse', 49, 'ascarse2x@google.ru');
-- insert into Person (Name, Surname, Age, Email) values ('Parnell', 'Abrahmer', 49, 'pabrahmer2y@google.de');
-- insert into Person (Name, Surname, Age, Email) values ('Elana', 'Hanwright', 35, 'ehanwright2z@phoca.cz');
-- insert into Person (Name, Surname, Age, Email) values ('Adeline', 'Starking', 63, 'astarking30@gmpg.org');
-- insert into Person (Name, Surname, Age, Email) values ('Shandeigh', 'Bouch', 16, 'sbouch31@desdev.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Mickey', 'Shasnan', 45, 'mshasnan32@hostgator.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ursa', 'Wichard', 23, 'uwichard33@blinklist.com');
-- insert into Person (Name, Surname, Age, Email) values ('Lanita', 'Kiernan', 35, 'lkiernan34@yellowbook.com');
-- insert into Person (Name, Surname, Age, Email) values ('Debby', 'Mawditt', 37, 'dmawditt35@nifty.com');
-- insert into Person (Name, Surname, Age, Email) values ('Chickie', 'Berns', 56, 'cberns36@acquirethisname.com');
-- insert into Person (Name, Surname, Age, Email) values ('Griselda', 'Dawbury', 30, 'gdawbury37@wiley.com');
-- insert into Person (Name, Surname, Age, Email) values ('Judie', 'Leeb', 53, 'jleeb38@google.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Rania', 'Lanceley', 36, 'rlanceley39@washington.edu');
-- insert into Person (Name, Surname, Age, Email) values ('Ulrike', 'Peiser', 42, 'upeiser3a@omniture.com');
-- insert into Person (Name, Surname, Age, Email) values ('Billye', 'Schaffler', 18, 'bschaffler3b@linkedin.com');
-- insert into Person (Name, Surname, Age, Email) values ('Gabriellia', 'Hembling', 36, 'ghembling3c@cmu.edu');
-- insert into Person (Name, Surname, Age, Email) values ('Bride', 'Waleworke', 22, 'bwaleworke3d@instagram.com');
-- insert into Person (Name, Surname, Age, Email) values ('Myrvyn', 'Baake', 29, 'mbaake3e@google.nl');
-- insert into Person (Name, Surname, Age, Email) values ('Stanly', 'Winsom', 35, 'swinsom3f@livejournal.com');
-- insert into Person (Name, Surname, Age, Email) values ('Jenelle', 'Ewles', 48, 'jewles3g@wordpress.com');
-- insert into Person (Name, Surname, Age, Email) values ('Elwyn', 'Cicchelli', 65, 'ecicchelli3h@tinyurl.com');
-- insert into Person (Name, Surname, Age, Email) values ('Hana', 'Brezlaw', 48, 'hbrezlaw3i@salon.com');
-- insert into Person (Name, Surname, Age, Email) values ('Lurline', 'Borthe', 50, 'lborthe3j@amazon.co.uk');
-- insert into Person (Name, Surname, Age, Email) values ('Meara', 'Barrass', 30, 'mbarrass3k@is.gd');
-- insert into Person (Name, Surname, Age, Email) values ('Ellsworth', 'Josefer', 59, 'ejosefer3l@desdev.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Kirk', 'Maffione', 28, 'kmaffione3m@clickbank.net');
-- insert into Person (Name, Surname, Age, Email) values ('Rachele', 'Eaton', 39, 'reaton3n@ca.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Marcy', 'Wollacott', 40, 'mwollacott3o@netvibes.com');
-- insert into Person (Name, Surname, Age, Email) values ('Nydia', 'Fowells', 22, 'nfowells3p@globo.com');
-- insert into Person (Name, Surname, Age, Email) values ('Delmar', 'Veque', 64, 'dveque3q@cnet.com');
-- insert into Person (Name, Surname, Age, Email) values ('Juieta', 'Tousey', 52, 'jtousey3r@google.pl');
-- insert into Person (Name, Surname, Age, Email) values ('Therese', 'Behrend', 30, 'tbehrend3s@mysql.com');
-- insert into Person (Name, Surname, Age, Email) values ('Zola', 'Corteney', 26, 'zcorteney3t@cnbc.com');
-- insert into Person (Name, Surname, Age, Email) values ('Ferrell', 'Ferrillo', 49, 'fferrillo3u@ucoz.com');
-- insert into Person (Name, Surname, Age, Email) values ('Alanah', 'Fernley', 54, 'afernley3v@lulu.com');
-- insert into Person (Name, Surname, Age, Email) values ('Evita', 'Speares', 20, 'espeares3w@china.com.cn');
-- insert into Person (Name, Surname, Age, Email) values ('Baudoin', 'Deschlein', 51, 'bdeschlein3x@chronoengine.com');
-- insert into Person (Name, Surname, Age, Email) values ('Thomasine', 'Antony', 44, 'tantony3y@ftc.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Royce', 'MacCrosson', 54, 'rmaccrosson3z@mysql.com');
-- insert into Person (Name, Surname, Age, Email) values ('Erinna', 'Nisen', 42, 'enisen40@usa.gov');
-- insert into Person (Name, Surname, Age, Email) values ('Ashli', 'Ludye', 52, 'aludye41@shop-pro.jp');
-- insert into Person (Name, Surname, Age, Email) values ('Reg', 'Fenge', 51, 'rfenge42@is.gd');
-- insert into Person (Name, Surname, Age, Email) values ('Jamey', 'Amorts', 36, 'jamorts43@bizjournals.com');
-- insert into Person (Name, Surname, Age, Email) values ('Paton', 'Vigietti', 33, 'pvigietti44@furl.net');
-- insert into Person (Name, Surname, Age, Email) values ('Grenville', 'Thackray', 63, 'gthackray45@creativecommons.org');

-- insert into Teachers (Salary, PersonId) values (1214.47, 1);
-- insert into Teachers (Salary, PersonId) values (2503.02, 2);
-- insert into Teachers (Salary, PersonId) values (2575.14, 3);
-- insert into Teachers (Salary, PersonId) values (4755.99, 4);
-- insert into Teachers (Salary, PersonId) values (5955.2, 5);
-- insert into Teachers (Salary, PersonId) values (643.71, 6);
-- insert into Teachers (Salary, PersonId) values (5188.25, 7);
-- insert into Teachers (Salary, PersonId) values (2875.14, 8);
-- insert into Teachers (Salary, PersonId) values (3164.08, 9);
-- insert into Teachers (Salary, PersonId) values (460.36, 10);
-- insert into Teachers (Salary, PersonId) values (621.97, 11);
-- insert into Teachers (Salary, PersonId) values (5467.32, 12);
-- insert into Teachers (Salary, PersonId) values (4407.8, 13);
-- insert into Teachers (Salary, PersonId) values (2367.04, 14);
-- insert into Teachers (Salary, PersonId) values (2945.63, 15);
-- insert into Teachers (Salary, PersonId) values (1564.13, 16);
-- insert into Teachers (Salary, PersonId) values (4408.46, 17);
-- insert into Teachers (Salary, PersonId) values (5764.75, 18);
-- insert into Teachers (Salary, PersonId) values (1310.61, 19);
-- insert into Teachers (Salary, PersonId) values (4519.94, 20);
-- insert into Teachers (Salary, PersonId) values (2478.74, 21);
-- insert into Teachers (Salary, PersonId) values (1247.85, 22);
-- insert into Teachers (Salary, PersonId) values (1161.2, 23);
-- insert into Teachers (Salary, PersonId) values (3368.32, 24);
-- insert into Teachers (Salary, PersonId) values (681.46, 25);
-- insert into Teachers (Salary, PersonId) values (1397.99, 26);
-- insert into Teachers (Salary, PersonId) values (2509.22, 27);
-- insert into Teachers (Salary, PersonId) values (5807.85, 28);
-- insert into Teachers (Salary, PersonId) values (2349.38, 29);




-- insert into Faculty(Name) values ('Faculty of Computer Science');
-- insert into Faculty(Name) values ('Faculty of Mathematics');
-- insert into Faculty(Name) values ('Faculty of Physics');
-- insert into Faculty(Name) values ('Faculty of Chemistry');
-- insert into Faculty(Name) values ('Faculty of Biology');
--
--
-- insert into Groups (Name, Course, FacultyId) values (30, 2, 3);
-- insert into Teachers (Name, Course, FacultyId) values (31, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (32, 2, 1);
-- insert into Teachers (Name, Course, FacultyId) values (33, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (34, 2, 3);
-- insert into Teachers (Name, Course, FacultyId) values (35, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (36, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (37, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (38, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (39, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (40, 1, 3);
-- insert into Teachers (Name, Course, FacultyId) values (41, 3, 5);
-- insert into Teachers (Name, Course, FacultyId) values (42, 2, 1);
-- insert into Teachers (Name, Course, FacultyId) values (43, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (44, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (45, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (46, 4, 1);
-- insert into Teachers (Name, Course, FacultyId) values (47, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (48, 2, 1);
-- insert into Teachers (Name, Course, FacultyId) values (49, 2, 1);
-- insert into Teachers (Name, Course, FacultyId) values (50, 3, 3);
-- insert into Teachers (Name, Course, FacultyId) values (51, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (52, 1, 3);
-- insert into Teachers (Name, Course, FacultyId) values (53, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (54, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (55, 4, 4);
-- insert into Teachers (Name, Course, FacultyId) values (56, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (57, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (58, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (59, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (60, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (61, 3, 1);
-- insert into Teachers (Name, Course, FacultyId) values (62, 3, 3);
-- insert into Teachers (Name, Course, FacultyId) values (63, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (64, 2, 3);
-- insert into Teachers (Name, Course, FacultyId) values (65, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (66, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (67, 2, 4);
-- insert into Teachers (Name, Course, FacultyId) values (68, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (69, 3, 3);
-- insert into Teachers (Name, Course, FacultyId) values (70, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (71, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (72, 4, 1);
-- insert into Teachers (Name, Course, FacultyId) values (73, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (74, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (75, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (76, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (77, 3, 3);
-- insert into Teachers (Name, Course, FacultyId) values (78, 2, 5);
-- insert into Teachers (Name, Course, FacultyId) values (79, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (80, 1, 3);
-- insert into Teachers (Name, Course, FacultyId) values (81, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (82, 3, 1);
-- insert into Teachers (Name, Course, FacultyId) values (83, 2, 3);
-- insert into Teachers (Name, Course, FacultyId) values (84, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (85, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (86, 4, 3);
-- insert into Teachers (Name, Course, FacultyId) values (87, 4, 2);
-- insert into Teachers (Name, Course, FacultyId) values (88, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (89, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (90, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (91, 4, 3);
-- insert into Teachers (Name, Course, FacultyId) values (92, 4, 2);
-- insert into Teachers (Name, Course, FacultyId) values (93, 4, 1);
-- insert into Teachers (Name, Course, FacultyId) values (94, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (95, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (96, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (97, 2, 1);
-- insert into Teachers (Name, Course, FacultyId) values (98, 4, 1);
-- insert into Teachers (Name, Course, FacultyId) values (99, 2, 1);
-- insert into Teachers (Name, Course, FacultyId) values (100, 4, 3);
-- insert into Teachers (Name, Course, FacultyId) values (101, 4, 2);
-- insert into Teachers (Name, Course, FacultyId) values (102, 4, 3);
-- insert into Teachers (Name, Course, FacultyId) values (103, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (104, 2, 4);
-- insert into Teachers (Name, Course, FacultyId) values (105, 4, 2);
-- insert into Teachers (Name, Course, FacultyId) values (106, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (107, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (108, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (109, 2, 5);
-- insert into Teachers (Name, Course, FacultyId) values (110, 4, 3);
-- insert into Teachers (Name, Course, FacultyId) values (111, 2, 4);
-- insert into Teachers (Name, Course, FacultyId) values (112, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (113, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (114, 2, 4);
-- insert into Teachers (Name, Course, FacultyId) values (115, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (116, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (117, 4, 1);
-- insert into Teachers (Name, Course, FacultyId) values (118, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (119, 1, 5);
-- insert into Teachers (Name, Course, FacultyId) values (120, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (121, 4, 4);
-- insert into Teachers (Name, Course, FacultyId) values (122, 3, 1);
-- insert into Teachers (Name, Course, FacultyId) values (123, 3, 1);
-- insert into Teachers (Name, Course, FacultyId) values (124, 2, 3);
-- insert into Teachers (Name, Course, FacultyId) values (125, 3, 1);
-- insert into Teachers (Name, Course, FacultyId) values (126, 4, 2);
-- insert into Teachers (Name, Course, FacultyId) values (127, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (128, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (129, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (130, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (131, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (132, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (133, 3, 5);
-- insert into Teachers (Name, Course, FacultyId) values (134, 1, 1);
-- insert into Teachers (Name, Course, FacultyId) values (135, 1, 4);
-- insert into Teachers (Name, Course, FacultyId) values (136, 3, 3);
-- insert into Teachers (Name, Course, FacultyId) values (137, 2, 4);
-- insert into Teachers (Name, Course, FacultyId) values (138, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (139, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (140, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (141, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (142, 2, 2);
-- insert into Teachers (Name, Course, FacultyId) values (143, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (144, 4, 5);
-- insert into Teachers (Name, Course, FacultyId) values (145, 3, 2);
-- insert into Teachers (Name, Course, FacultyId) values (146, 1, 2);
-- insert into Teachers (Name, Course, FacultyId) values (147, 2, 4);
-- insert into Teachers (Name, Course, FacultyId) values (148, 3, 4);
-- insert into Teachers (Name, Course, FacultyId) values (149, 1, 4);
--

insert into Groups(Name, FacultyId) values ('Group 1', 1);
insert into Groups(Name, FacultyId) values ('Group 2', 1);
insert into Groups(Name, FacultyId) values ('Group 3', 1);
insert into Groups(Name, FacultyId) values ('Group 4', 1);
insert into Groups(Name, FacultyId) values ('Group 5', 1);
insert into Groups(Name, FacultyId) values ('Group 6', 2);
insert into Groups(Name, FacultyId) values ('Group 7', 2);
insert into Groups(Name, FacultyId) values ('Group 8', 2);
insert into Groups(Name, FacultyId) values ('Group 9', 2);
insert into Groups(Name, FacultyId) values ('Group 10', 2);
insert into Groups(Name, FacultyId) values ('Group 11', 3);
insert into Groups(Name, FacultyId) values ('Group 12', 3);
insert into Groups(Name, FacultyId) values ('Group 13', 3);
insert into Groups(Name, FacultyId) values ('Group 14', 3);
insert into Groups(Name, FacultyId) values ('Group 15', 3);
insert into Groups(Name, FacultyId) values ('Group 16', 4);
insert into Groups(Name, FacultyId) values ('Group 17', 4);
insert into Groups(Name, FacultyId) values ('Group 18', 4);
insert into Groups(Name, FacultyId) values ('Group 19', 4);
insert into Groups(Name, FacultyId) values ('Group 20', 4);
insert into Groups(Name, FacultyId) values ('Group 21', 5);
insert into Groups(Name, FacultyId) values ('Group 22', 5);
insert into Groups(Name, FacultyId) values ('Group 23', 5);
insert into Groups(Name, FacultyId) values ('Group 24', 5);
insert into Groups(Name, FacultyId) values ('Group 25', 5);


insert into GroupTeachers (TeacherId, GroupId) values (23, 18);
insert into GroupTeachers (TeacherId, GroupId) values (5, 2);
insert into GroupTeachers (TeacherId, GroupId) values (8, 19);
insert into GroupTeachers (TeacherId, GroupId) values (21, 3);
insert into GroupTeachers (TeacherId, GroupId) values (5, 17);
insert into GroupTeachers (TeacherId, GroupId) values (11, 10);
insert into GroupTeachers (TeacherId, GroupId) values (25, 1);
insert into GroupTeachers (TeacherId, GroupId) values (29, 4);
insert into GroupTeachers (TeacherId, GroupId) values (21, 20);
insert into GroupTeachers (TeacherId, GroupId) values (23, 22);
insert into GroupTeachers (TeacherId, GroupId) values (24, 17);
insert into GroupTeachers (TeacherId, GroupId) values (8, 7);
insert into GroupTeachers (TeacherId, GroupId) values (12, 10);
insert into GroupTeachers (TeacherId, GroupId) values (9, 11);
insert into GroupTeachers (TeacherId, GroupId) values (7, 2);
insert into GroupTeachers (TeacherId, GroupId) values (10, 19);
insert into GroupTeachers (TeacherId, GroupId) values (3, 24);
insert into GroupTeachers (TeacherId, GroupId) values (28, 18);
insert into GroupTeachers (TeacherId, GroupId) values (9, 11);
insert into GroupTeachers (TeacherId, GroupId) values (4, 7);
insert into GroupTeachers (TeacherId, GroupId) values (16, 12);
insert into GroupTeachers (TeacherId, GroupId) values (4, 1);
insert into GroupTeachers (TeacherId, GroupId) values (11, 5);
insert into GroupTeachers (TeacherId, GroupId) values (1, 19);
insert into GroupTeachers (TeacherId, GroupId) values (19, 19);
insert into GroupTeachers (TeacherId, GroupId) values (8, 1);
insert into GroupTeachers (TeacherId, GroupId) values (28, 20);
insert into GroupTeachers (TeacherId, GroupId) values (17, 8);
insert into GroupTeachers (TeacherId, GroupId) values (8, 17);
insert into GroupTeachers (TeacherId, GroupId) values (6, 6);
insert into GroupTeachers (TeacherId, GroupId) values (15, 8);
insert into GroupTeachers (TeacherId, GroupId) values (24, 11);
insert into GroupTeachers (TeacherId, GroupId) values (20, 10);
insert into GroupTeachers (TeacherId, GroupId) values (28, 7);
insert into GroupTeachers (TeacherId, GroupId) values (1, 17);
insert into GroupTeachers (TeacherId, GroupId) values (26, 21);
insert into GroupTeachers (TeacherId, GroupId) values (8, 19);
insert into GroupTeachers (TeacherId, GroupId) values (25, 8);
insert into GroupTeachers (TeacherId, GroupId) values (7, 2);
insert into GroupTeachers (TeacherId, GroupId) values (8, 21);
insert into GroupTeachers (TeacherId, GroupId) values (22, 10);
insert into GroupTeachers (TeacherId, GroupId) values (25, 10);
insert into GroupTeachers (TeacherId, GroupId) values (29, 9);
insert into GroupTeachers (TeacherId, GroupId) values (5, 15);
insert into GroupTeachers (TeacherId, GroupId) values (11, 7);
insert into GroupTeachers (TeacherId, GroupId) values (1, 9);
insert into GroupTeachers (TeacherId, GroupId) values (10, 24);
insert into GroupTeachers (TeacherId, GroupId) values (21, 14);
insert into GroupTeachers (TeacherId, GroupId) values (28, 2);
insert into GroupTeachers (TeacherId, GroupId) values (23, 3);
insert into GroupTeachers (TeacherId, GroupId) values (22, 13);
insert into GroupTeachers (TeacherId, GroupId) values (29, 25);
insert into GroupTeachers (TeacherId, GroupId) values (14, 17);
insert into GroupTeachers (TeacherId, GroupId) values (29, 4);
insert into GroupTeachers (TeacherId, GroupId) values (19, 18);
insert into GroupTeachers (TeacherId, GroupId) values (2, 19);
insert into GroupTeachers (TeacherId, GroupId) values (3, 18);
insert into GroupTeachers (TeacherId, GroupId) values (24, 22);
insert into GroupTeachers (TeacherId, GroupId) values (3, 9);
insert into GroupTeachers (TeacherId, GroupId) values (6, 5);
insert into GroupTeachers (TeacherId, GroupId) values (13, 11);
insert into GroupTeachers (TeacherId, GroupId) values (19, 2);
insert into GroupTeachers (TeacherId, GroupId) values (15, 2);
insert into GroupTeachers (TeacherId, GroupId) values (9, 1);
insert into GroupTeachers (TeacherId, GroupId) values (23, 17);
insert into GroupTeachers (TeacherId, GroupId) values (3, 24);
insert into GroupTeachers (TeacherId, GroupId) values (22, 1);
insert into GroupTeachers (TeacherId, GroupId) values (27, 6);
insert into GroupTeachers (TeacherId, GroupId) values (1, 20);
insert into GroupTeachers (TeacherId, GroupId) values (17, 17);
insert into GroupTeachers (TeacherId, GroupId) values (29, 6);
insert into GroupTeachers (TeacherId, GroupId) values (14, 16);
insert into GroupTeachers (TeacherId, GroupId) values (29, 4);
insert into GroupTeachers (TeacherId, GroupId) values (18, 5);
insert into GroupTeachers (TeacherId, GroupId) values (25, 6);
insert into GroupTeachers (TeacherId, GroupId) values (5, 4);
insert into GroupTeachers (TeacherId, GroupId) values (2, 10);
insert into GroupTeachers (TeacherId, GroupId) values (6, 21);
insert into GroupTeachers (TeacherId, GroupId) values (4, 8);
insert into GroupTeachers (TeacherId, GroupId) values (6, 2);
insert into GroupTeachers (TeacherId, GroupId) values (12, 20);
insert into GroupTeachers (TeacherId, GroupId) values (15, 13);
insert into GroupTeachers (TeacherId, GroupId) values (9, 11);
insert into GroupTeachers (TeacherId, GroupId) values (8, 24);
insert into GroupTeachers (TeacherId, GroupId) values (18, 10);
insert into GroupTeachers (TeacherId, GroupId) values (11, 22);
insert into GroupTeachers (TeacherId, GroupId) values (16, 3);
insert into GroupTeachers (TeacherId, GroupId) values (11, 12);
insert into GroupTeachers (TeacherId, GroupId) values (29, 18);
insert into GroupTeachers (TeacherId, GroupId) values (14, 11);
insert into GroupTeachers (TeacherId, GroupId) values (26, 23);
insert into GroupTeachers (TeacherId, GroupId) values (8, 21);
insert into GroupTeachers (TeacherId, GroupId) values (21, 25);
insert into GroupTeachers (TeacherId, GroupId) values (26, 19);
insert into GroupTeachers (TeacherId, GroupId) values (17, 1);
insert into GroupTeachers (TeacherId, GroupId) values (9, 25);
insert into GroupTeachers (TeacherId, GroupId) values (5, 23);
insert into GroupTeachers (TeacherId, GroupId) values (22, 11);
insert into GroupTeachers (TeacherId, GroupId) values (6, 12);
insert into GroupTeachers (TeacherId, GroupId) values (25, 14);



select Groups.id as [GroupId], Groups.Name, Faculty.Id as [FacultyId], Faculty.Name from Groups
inner join Faculty on Faculty.Id = Groups.FacultyId


insert into Students(GroupId) values ('Mccullough', 1);


insert into Students (PersonId, GPA, GroupId) values (1, 0.13, 14);
insert into Students (PersonId, GPA, GroupId) values (2, 3.49, 17);
insert into Students (PersonId, GPA, GroupId) values (3, 1.22, 16);
insert into Students (PersonId, GPA, GroupId) values (4, 0.1, 16);
insert into Students (PersonId, GPA, GroupId) values (5, 0.07, 10);
insert into Students (PersonId, GPA, GroupId) values (6, 0.14, 15);
insert into Students (PersonId, GPA, GroupId) values (7, 1.2, 7);
insert into Students (PersonId, GPA, GroupId) values (8, 4.15, 9);
insert into Students (PersonId, GPA, GroupId) values (9, 0.13, 15);
insert into Students (PersonId, GPA, GroupId) values (10, 3.2, 24);
insert into Students (PersonId, GPA, GroupId) values (11, 2.06, 9);
insert into Students (PersonId, GPA, GroupId) values (12, 2.91, 2);
insert into Students (PersonId, GPA, GroupId) values (13, 3.36, 13);
insert into Students (PersonId, GPA, GroupId) values (14, 4.71, 23);
insert into Students (PersonId, GPA, GroupId) values (15, 3.24, 1);
insert into Students (PersonId, GPA, GroupId) values (16, 3.62, 7);
insert into Students (PersonId, GPA, GroupId) values (17, 0.37, 8);
insert into Students (PersonId, GPA, GroupId) values (18, 2.52, 11);
insert into Students (PersonId, GPA, GroupId) values (19, 0.87, 6);
insert into Students (PersonId, GPA, GroupId) values (20, 0.31, 24);
insert into Students (PersonId, GPA, GroupId) values (21, 1.76, 6);
insert into Students (PersonId, GPA, GroupId) values (22, 2.41, 21);
insert into Students (PersonId, GPA, GroupId) values (23, 1.64, 17);
insert into Students (PersonId, GPA, GroupId) values (24, 2.3, 9);
insert into Students (PersonId, GPA, GroupId) values (25, 3.86, 5);
insert into Students (PersonId, GPA, GroupId) values (26, 0.45, 10);
insert into Students (PersonId, GPA, GroupId) values (27, 0.36, 1);
insert into Students (PersonId, GPA, GroupId) values (28, 4.8, 19);
insert into Students (PersonId, GPA, GroupId) values (29, 1.08, 2);
insert into Students (PersonId, GPA, GroupId) values (30, 4.43, 23);
insert into Students (PersonId, GPA, GroupId) values (31, 0.11, 9);
insert into Students (PersonId, GPA, GroupId) values (32, 3.92, 3);
insert into Students (PersonId, GPA, GroupId) values (33, 2.36, 23);
insert into Students (PersonId, GPA, GroupId) values (34, 0.43, 13);
insert into Students (PersonId, GPA, GroupId) values (35, 3.75, 20);
insert into Students (PersonId, GPA, GroupId) values (36, 2.44, 14);
insert into Students (PersonId, GPA, GroupId) values (37, 0.05, 9);
insert into Students (PersonId, GPA, GroupId) values (38, 1.44, 14);
insert into Students (PersonId, GPA, GroupId) values (39, 1.09, 25);
insert into Students (PersonId, GPA, GroupId) values (40, 3.27, 13);
insert into Students (PersonId, GPA, GroupId) values (41, 1.75, 16);
insert into Students (PersonId, GPA, GroupId) values (42, 2.27, 22);
insert into Students (PersonId, GPA, GroupId) values (43, 3.32, 1);
insert into Students (PersonId, GPA, GroupId) values (44, 2.38, 23);
insert into Students (PersonId, GPA, GroupId) values (45, 3.33, 13);
insert into Students (PersonId, GPA, GroupId) values (46, 3.97, 1);
insert into Students (PersonId, GPA, GroupId) values (47, 2.22, 3);
insert into Students (PersonId, GPA, GroupId) values (48, 2.7, 13);
insert into Students (PersonId, GPA, GroupId) values (49, 1.35, 22);
insert into Students (PersonId, GPA, GroupId) values (50, 0.75, 13);
insert into Students (PersonId, GPA, GroupId) values (51, 0.85, 11);
insert into Students (PersonId, GPA, GroupId) values (52, 0.4, 24);
insert into Students (PersonId, GPA, GroupId) values (53, 3.86, 19);
insert into Students (PersonId, GPA, GroupId) values (54, 0.6, 9);
insert into Students (PersonId, GPA, GroupId) values (55, 2.42, 7);
insert into Students (PersonId, GPA, GroupId) values (56, 3.06, 16);
insert into Students (PersonId, GPA, GroupId) values (57, 1.01, 21);
insert into Students (PersonId, GPA, GroupId) values (58, 4.3, 5);
insert into Students (PersonId, GPA, GroupId) values (59, 2.14, 5);
insert into Students (PersonId, GPA, GroupId) values (60, 3.58, 18);
insert into Students (PersonId, GPA, GroupId) values (61, 0.6, 20);
insert into Students (PersonId, GPA, GroupId) values (62, 2.1, 12);
insert into Students (PersonId, GPA, GroupId) values (63, 4.79, 1);
insert into Students (PersonId, GPA, GroupId) values (64, 1.54, 5);
insert into Students (PersonId, GPA, GroupId) values (65, 0.8, 14);
insert into Students (PersonId, GPA, GroupId) values (66, 3.55, 9);
insert into Students (PersonId, GPA, GroupId) values (67, 1.52, 21);
insert into Students (PersonId, GPA, GroupId) values (68, 3.93, 11);
insert into Students (PersonId, GPA, GroupId) values (69, 0.96, 3);
insert into Students (PersonId, GPA, GroupId) values (70, 2.37, 2);
insert into Students (PersonId, GPA, GroupId) values (71, 4.47, 1);
insert into Students (PersonId, GPA, GroupId) values (72, 1.3, 22);
insert into Students (PersonId, GPA, GroupId) values (73, 4.12, 18);
insert into Students (PersonId, GPA, GroupId) values (74, 1.11, 24);
insert into Students (PersonId, GPA, GroupId) values (75, 3.32, 21);
insert into Students (PersonId, GPA, GroupId) values (76, 0.12, 21);
insert into Students (PersonId, GPA, GroupId) values (77, 4.13, 11);
insert into Students (PersonId, GPA, GroupId) values (78, 0.7, 15);
insert into Students (PersonId, GPA, GroupId) values (79, 3.48, 14);
insert into Students (PersonId, GPA, GroupId) values (80, 4.87, 19);
insert into Students (PersonId, GPA, GroupId) values (81, 4.44, 15);
insert into Students (PersonId, GPA, GroupId) values (82, 4.75, 18);
insert into Students (PersonId, GPA, GroupId) values (83, 3.12, 25);
insert into Students (PersonId, GPA, GroupId) values (84, 1.24, 12);
insert into Students (PersonId, GPA, GroupId) values (85, 3.69, 3);
insert into Students (PersonId, GPA, GroupId) values (86, 3.33, 4);
insert into Students (PersonId, GPA, GroupId) values (87, 3.44, 3);
insert into Students (PersonId, GPA, GroupId) values (88, 4.26, 4);
insert into Students (PersonId, GPA, GroupId) values (89, 1.12, 16);
insert into Students (PersonId, GPA, GroupId) values (90, 0.28, 24);
insert into Students (PersonId, GPA, GroupId) values (91, 2.14, 5);
insert into Students (PersonId, GPA, GroupId) values (92, 1.61, 4);
insert into Students (PersonId, GPA, GroupId) values (93, 2.91, 4);
insert into Students (PersonId, GPA, GroupId) values (94, 4.74, 3);
insert into Students (PersonId, GPA, GroupId) values (95, 4.13, 1);
insert into Students (PersonId, GPA, GroupId) values (96, 1.45, 12);
insert into Students (PersonId, GPA, GroupId) values (97, 1.54, 4);
insert into Students (PersonId, GPA, GroupId) values (98, 1.09, 12);
insert into Students (PersonId, GPA, GroupId) values (99, 0.68, 2);
insert into Students (PersonId, GPA, GroupId) values (100, 2.41, 6);
insert into Students (PersonId, GPA, GroupId) values (101, 4.86, 25);
insert into Students (PersonId, GPA, GroupId) values (102, 1.71, 18);
insert into Students (PersonId, GPA, GroupId) values (103, 1.08, 16);
insert into Students (PersonId, GPA, GroupId) values (104, 3.71, 7);
insert into Students (PersonId, GPA, GroupId) values (105, 2.52, 13);
insert into Students (PersonId, GPA, GroupId) values (106, 1.77, 3);
insert into Students (PersonId, GPA, GroupId) values (107, 1.23, 3);
insert into Students (PersonId, GPA, GroupId) values (108, 4.1, 6);
insert into Students (PersonId, GPA, GroupId) values (109, 3.04, 3);
insert into Students (PersonId, GPA, GroupId) values (110, 3.48, 14);
insert into Students (PersonId, GPA, GroupId) values (111, 0.1, 16);
insert into Students (PersonId, GPA, GroupId) values (112, 4.15, 2);
insert into Students (PersonId, GPA, GroupId) values (113, 4.92, 23);
insert into Students (PersonId, GPA, GroupId) values (114, 0.75, 12);
insert into Students (PersonId, GPA, GroupId) values (115, 2.29, 1);
insert into Students (PersonId, GPA, GroupId) values (116, 4.66, 3);
insert into Students (PersonId, GPA, GroupId) values (117, 1.5, 4);
insert into Students (PersonId, GPA, GroupId) values (118, 4.85, 8);
insert into Students (PersonId, GPA, GroupId) values (119, 4.05, 6);
insert into Students (PersonId, GPA, GroupId) values (120, 4.41, 5);
insert into Students (PersonId, GPA, GroupId) values (121, 4.6, 25);
insert into Students (PersonId, GPA, GroupId) values (122, 0.37, 16);
insert into Students (PersonId, GPA, GroupId) values (123, 1.34, 1);
insert into Students (PersonId, GPA, GroupId) values (124, 1.41, 1);
insert into Students (PersonId, GPA, GroupId) values (125, 2.88, 3);
insert into Students (PersonId, GPA, GroupId) values (126, 4.08, 20);
insert into Students (PersonId, GPA, GroupId) values (127, 2.78, 11);
insert into Students (PersonId, GPA, GroupId) values (128, 2.33, 25);
insert into Students (PersonId, GPA, GroupId) values (129, 1.99, 8);
insert into Students (PersonId, GPA, GroupId) values (130, 3.8, 24);
insert into Students (PersonId, GPA, GroupId) values (131, 1.07, 1);
insert into Students (PersonId, GPA, GroupId) values (132, 4.97, 9);
insert into Students (PersonId, GPA, GroupId) values (133, 1.29, 16);
insert into Students (PersonId, GPA, GroupId) values (134, 3.05, 18);
insert into Students (PersonId, GPA, GroupId) values (135, 3.94, 15);
insert into Students (PersonId, GPA, GroupId) values (136, 3.67, 9);
insert into Students (PersonId, GPA, GroupId) values (137, 1.16, 23);
insert into Students (PersonId, GPA, GroupId) values (138, 3.46, 25);
insert into Students (PersonId, GPA, GroupId) values (139, 3.09, 12);
insert into Students (PersonId, GPA, GroupId) values (140, 4.51, 21);
insert into Students (PersonId, GPA, GroupId) values (141, 0.47, 20);
insert into Students (PersonId, GPA, GroupId) values (142, 3.89, 16);
insert into Students (PersonId, GPA, GroupId) values (143, 2.21, 19);
insert into Students (PersonId, GPA, GroupId) values (144, 2.34, 5);
insert into Students (PersonId, GPA, GroupId) values (145, 1.49, 11);
insert into Students (PersonId, GPA, GroupId) values (146, 4.3, 5);
insert into Students (PersonId, GPA, GroupId) values (147, 3.42, 10);
insert into Students (PersonId, GPA, GroupId) values (148, 4.0, 3);
insert into Students (PersonId, GPA, GroupId) values (149, 1.03, 1);


select * from Students
inner join Groups G on G.Id = Students.GroupId
inner join Person P on P.Id = Students.PersonId