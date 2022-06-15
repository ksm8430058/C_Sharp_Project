use MoogaBox

--drop table Movie;
--drop table Theater;
--drop table Member;
--drop table Reservation;
--drop table TmpReservation;
--drop table Snack;
--drop table BuySnack;
--drop table TmpBuySnack;
--drop table Jaego;
--drop table Maejum;
--drop table Balju;
--drop table Edong;



create table Movie						--영화 테이블
(
MvName nvarchar(20) ,  --영화이름
Hall Int,								--상영관( 관 하나에 하나의 영화만 상영)
StartTime time,							--영화 시작 시간
RunningTime time							--영화 러닝 시간
);



create table Theater					--상영관 테이블
(
ThNum int Not null,			--상영관 번호
SeatNum varchar(20),					--상영관 좌석 번호
Eempty int								--상영관 좌석 예매여부 
);

create table Member            
(
ID varchar(10) Not null Primary Key,
PW varchar(20),
Phone varchar(20),
Who int                     
);

create table Reservation						--예매 테이블
(
ID varchar(20) ,
RsvCode varchar(20)  ,		--예매번호 (데이터는 랜덤값으로 )
MvName nvarchar(20),	--예매 영화 이름
Hall int,										--예매 영화 상영관
SeatNum varchar(20),							--예매 좌석 번호
StartTime time,							--영화 시작 시간
RunningTime time,								--영화 러닝 시간
Ccount int,										--예매 사람 수
Mmoney int										--총  구매 금액
);

create table TmpReservation						--예매 임시 테이블
(
ID varchar(20) ,
MvName nvarchar(20),	--예매 영화 이름
Hall int,										--예매 영화 상영관
SeatNum varchar(20),							--예매 좌석 번호
StartTime time,							--영화 시작 시간
RunningTime time,								--영화 러닝 시간
Ccount int,										--예매 사람 수
Mmoney int										--총  구매 금액
);

create table Snack							--스낵 테이블
(
SnackName nvarchar(10),
SnackNum varchar(10) ,  --팝콘 카라멜 큰거 = P01L / 팝콘 고소한맛 중간 = P02M 
SnackPrice int
);

create table BuySnack						--매점에서 구매한 스낵 테이블
(
ID varchar(10)  ,
SnackName nvarchar(10),
SnackNum varchar(10),
BuyPrice int,
BuyCount int,
SnackPrice int
);

create table TmpBuySnack                  --매점에서 구매  임시 테이블
(
ID varchar(10)  ,
SnackName nvarchar(10),
SnackNum varchar(10) ,
BuyPrice int,
BuyCount int,
SnackPrice int
);

create table Jaego
(
SnackName nvarchar(10),
SnackNum varchar(10) ,
SnackCount int
);

create table Maejum
(
SnackName nvarchar(10),
SnackNum varchar(10) ,
SnackCount int
);


create table Balju
(
SnackName nvarchar(10),
SnackNum varchar(10) Not null,
SnackCount int,
BalNum int identity(1,1)
);

create table Edong
(
SnackName nvarchar(10),
SnackNum varchar(10) Not null,
SnackCount int,
EdongNum int identity(1,1)
);

INSERT INTO Movie
values ('닥터 스트레인지', 1, '10:10:00', '02:06:00'),
('닥터 스트레인지', 1, '12:45:00', '02:06:00'),
 ('닥터 스트레인지', 1, '15:20:00', '02:06:00'),
('닥터 스트레인지', 1, '17:55:00', '02:06:00'),
 ('닥터 스트레인지', 1, '20:30:00', '02:06:00')
, ('닥터 스트레인지', 1, '23:05:00', '02:06:00');


INSERT INTO Movie
values ('범죄도시2', 2, '10:30', '01:46:00'),
('범죄도시2', 2, '12:15', '01:46:00'),
('범죄도시2', 2, '14:30', '01:46:00'),
('범죄도시2', 2, '16:45', '01:46:00'),
('범죄도시2', 2, '19:00', '01:46:00'),
('범죄도시2', 2, '21:15', '01:46:00'),
('범죄도시2', 2, '23:30', '01:46:00'
);

INSERT INTO Movie
values
('쥬라기 월드: 도미니언', 3, '09:40', '02:27:00'),
('쥬라기 월드: 도미니언', 3, '13:00', '02:27:00'),
('쥬라기 월드: 도미니언', 3, '15:20', '02:27:00'),
('쥬라기 월드: 도미니언', 3, '17:40', '02:27:00'),
('쥬라기 월드: 도미니언', 3, '20:00', '02:27:00'),
('쥬라기 월드: 도미니언', 3, '22:20', '02:27:00');

INSERT INTO Snack
values
('고소팝콘(M)', 'P01M', 4000),
('고소팝콘(L)', 'P01L', 5000),
('달콤팝콘(M)', 'P02M', 5000),
('달콤팝콘(L)', 'P02L', 6000),
('더블치즈팝콘(M)', 'P03M', 5500),
('더블치즈팝콘(L)', 'P03L', 6000),
('바질어니언팝콘(M)', 'P04M', 5500),
('바질어니언팝콘(L)', 'P04L', 6000);

INSERT INTO Snack
values
('코카콜라(M)', 'D01M', 2500),
('코카콜라(L)', 'D01L', 3000),
('스프라이트(M)', 'D02M', 2500),
('스프라이트(L)', 'D02L', 3000),
('환타오렌지(M)', 'D03M', 2500),
('환타오렌지(L)', 'D03L', 3000),
('환타파인애플(M)', 'D04M', 2500),
('환타파인애플(L)', 'D04L', 3000),

('무성콤보', 'C01M', 9000),--팝콘(L)1+탄산음료(M)2)
('더블콤보', 'C02D', 12000),  --  콘(M)2+탄산음료(M)2
('스몰콤보', 'C04S', 6500) , --팝콘(M)1+탄산음료(M)1
('라지콤보', 'C03L', 14000) --팝콘(L)2+탄산음료(L)2

;

INSERT INTO Maejum
values
('고소팝콘(M)', 'P01M', 500),
('고소팝콘(L)', 'P01L', 500),
('달콤팝콘(M)', 'P02M', 500),
('달콤팝콘(L)', 'P02L', 500),
('더블치즈팝콘(M)', 'P03M', 500),
('더블치즈팝콘(L)', 'P03L', 500),
('바질어니언팝콘(M)', 'P04M', 500),
('바질어니언팝콘(L)', 'P04L', 500);

INSERT INTO Maejum
values
('코카콜라(M)', 'D01M', 500),
('코카콜라(L)', 'D01L', 500),
('스프라이트(M)', 'D02M', 500),
('스프라이트(L)', 'D02L', 500),
('환타오렌지(M)', 'D03M', 500),
('환타오렌지(L)', 'D03L', 500),
('환타파인애플(M)', 'D04M', 500),
('환타파인애플(L)', 'D04L', 500);


INSERT INTO Jaego
values
('팝콘컵(M)', 'PC01M', 500),
('팝콘컵(L)', 'PC01L', 500),
('옥수수', 'CO01', 1000),
('버터', 'BT01', 1000),
('시즈닝(달콤)', 'SD01', 1000),
('시즈닝(치즈)', 'SC01', 1000),
('시즈닝(어니언)', 'SO01', 1000),
('탄산수', 'SW01', 5000),
('콜라시럽', 'CS01', 2000),
('스프라이트시럽', 'SS01', 2000),
('환타오렌지시럽', 'OS01', 2000),
('환타파인애플시럽', 'PS01', 2000);



INSERT INTO Theater
values
(1, 'A01', 0),
(1, 'A02', 0),
(1, 'A03', 0),
(1, 'A04', 0),
(1, 'A05', 0),
(1, 'B01', 0),
(1, 'B02', 0),
(1, 'B03', 0),
(1, 'B04', 0),
(1, 'B05', 0),
(1, 'C01', 0),
(1, 'C02', 0),
(1, 'C03', 0),
(1, 'C04', 0),
(1, 'C05', 0),
(1, 'D01', 0),
(1, 'D02', 0),
(1, 'D03', 0),
(1, 'D04', 0),
(1, 'D05', 0),

(2, 'A01', 0),
(2, 'A02', 0),
(2, 'A03', 0),
(2, 'A04', 0),
(2, 'A05', 0),
(2, 'B01', 0),
(2, 'B02', 0),
(2, 'B03', 0),
(2, 'B04', 0),
(2, 'B05', 0),
(2, 'C01', 0),
(2, 'C02', 0),
(2, 'C03', 0),
(2, 'C04', 0),
(2, 'C05', 0),
(2, 'D01', 0),
(2, 'D02', 0),
(2, 'D03', 0),
(2, 'D04', 0),
(2, 'D05', 0),

(3, 'A01', 0),
(3, 'A02', 0),
(3, 'A03', 0),
(3, 'A04', 0),
(3, 'A05', 0),
(3, 'B01', 0),
(3, 'B02', 0),
(3, 'B03', 0),
(3, 'B04', 0),
(3, 'B05', 0),
(3, 'C01', 0),
(3, 'C02', 0),
(3, 'C03', 0),
(3, 'C04', 0),
(3, 'C05', 0),
(3, 'D01', 0),
(3, 'D02', 0),
(3, 'D03', 0),
(3, 'D04', 0),
(3, 'D05', 0)
;

INSERT INTO Member
values
('rhksflwk', '0000',  '010-1111-2222', 1),
('ghldnjs1', 'qwe123','010-1111-2222', 0), --관리자면 1, 손님이면 0
('ghldnjs2', 'q1q2q3','010-1111-2222', 0),
('ghldnjs3', 'abc123','010-1111-2222', 0);

alter table Movie add MvNum varchar(10);

UPDATE Movie Set MvNum = 'DR01' WHERE StartTime = '10:10:00';
UPDATE Movie Set MvNum = 'DR02' WHERE StartTime = '12:45:00';
UPDATE Movie Set MvNum = 'DR03' WHERE StartTime = '15:20:00';
UPDATE Movie Set MvNum = 'DR04' WHERE StartTime = '17:55:00';
UPDATE Movie Set MvNum = 'DR05' WHERE StartTime = '20:30:00';
UPDATE Movie Set MvNum = 'DR06' WHERE StartTime = '23:05:00';

UPDATE Movie Set MvNum = 'CC01' WHERE StartTime = '10:30:00';
UPDATE Movie Set MvNum = 'CC02' WHERE StartTime = '12:15:00';
UPDATE Movie Set MvNum = 'CC03' WHERE StartTime = '14:30:00';
UPDATE Movie Set MvNum = 'CC04' WHERE StartTime = '16:45:00';
UPDATE Movie Set MvNum = 'CC05' WHERE StartTime = '19:00:00';
UPDATE Movie Set MvNum = 'CC06' WHERE StartTime = '21:15:00';
UPDATE Movie Set MvNum = 'CC07' WHERE StartTime = '23:30:00';
UPDATE Movie Set MvNum = 'DR03' WHERE StartTime = '15:20:00' and MvName ='닥터 스트레인지'

UPDATE Movie Set MvNum = 'JW01' WHERE StartTime = '09:40:00';
UPDATE Movie Set MvNum = 'JW02' WHERE StartTime = '13:00:00';
UPDATE Movie Set MvNum = 'JW03' WHERE StartTime = '15:20:00' and MvName ='쥬라기 월드:도미니언'
UPDATE Movie Set MvNum = 'JW04' WHERE StartTime = '17:40:00';
UPDATE Movie Set MvNum = 'JW05' WHERE StartTime = '20:00:00';
UPDATE Movie Set MvNum = 'JW06' WHERE StartTime = '22:20:00';

UPDATE Movie Set MvNum = 'JW03' WHERE StartTime = '15:20:00' and Hall = 3
select * from Movie



create table CrJo
(
MvName nvarchar(20) ,  --영화이름
Hall Int,                        --상영관( 관 하나에 하나의 영화만 상영)
StartTime time,                     --영화 시작 시간
RunningTime time,
MvNum varchar(10),                     --영화 러닝 시간
ThNum int Not null,         --상영관 번호
SeatNum varchar(20),               --상영관 좌석 번호
Eempty int                        --상영관 좌석 예매여부 
);

INSERT INTO CrJo 
(
MvName  ,  --영화이름
Hall ,                        --상영관( 관 하나에 하나의 영화만 상영)
StartTime ,                     --영화 시작 시간
RunningTime ,
MvNum,                     --영화 러닝 시간
ThNum  ,         --상영관 번호
SeatNum,               --상영관 좌석 번호
Eempty                         --상영관 좌석 예매여부 
)

select * from Movie cross join Theater where Movie.Hall =Theater.ThNum
