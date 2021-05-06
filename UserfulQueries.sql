use commerceapp


select * from userToNotifications
delete from userToNotifications where notificationID = 40;
--selects bank accounts, and their usernames
select uta.userID,asp.UserName, a.accountID, a.balance, a.lasttransaction 
	from userstoaccounts as uta 
		left join accounts as a on uta.accountID = a.accountID 
		left join AspNetUsers as asp on uta.userID = asp.Id

select  utn.userID, utn.notificationID as ID, 
	coalesce(  CAST(ac.min as varchar), CONVERT(varchar(15),CAST(tc.time_in AS TIME),100), 'Matches') as Parameter1, 
	coalesce( CAST(ac.max as varchar), CONVERT(varchar(15),CAST(tc.time_out AS TIME),100) , lc.location) as Parameter2, 
	Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec,
	(Jan + Feb + Mar + Apr + May + Jun + Jul + Aug + Sep + Oct + Nov + Dec) as YearlySum
	from userToNotifications as utn 
	left join amount_constraint as ac on utn.notificationID = ac.notificationID
	left join time_constraint as tc on utn.notificationID = tc.notificationID
	left join location_constraint as lc on utn.notificationID = lc.notificationID
	where utn.userID = '88dbfba3-2ee4-4ffd-85df-c4169f9bd800'


select notificationID, CONVERT(varchar(15),CAST(time_in AS TIME),100) from time_constraint

select * from time_constraint
select * from location_constraint
select * from amount_constraint
select * from triggeredNotif order by trigNotifId desc
select * from transactionsmaster order by transactiondate desc

select * from time_constraint as tc union (select * from location_constraint as lc)
select * from userToNotifications where userID = 'b48b3368-019a-4ef3-bcd7-2f9a425eaac7'
select * from AspNetUsers where Email = 'billyboi@gmail.com'


delete from userToNotifications where notificationID = 1;
delete from location_constraint where notificationID = 1;
select * from userToNotifications
insert into location_constraint values (1, 'Target');

--USE commerceapp
--Go
--CREATE PROCEDURE joinAllNotifs
--	@userID nvarchar(450)
--AS
--	select  utn.userID, utn.notificationID as ID, 
--	coalesce(  CAST(ac.min as varchar), CONVERT(varchar(15),CAST(tc.time_in AS TIME),100), 'Matches') as Parameter1, 
--	coalesce( CAST(ac.max as varchar), CONVERT(varchar(15),CAST(tc.time_out AS TIME),100) , lc.location) as Parameter2, 
--	Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec 
--	from userToNotifications as utn 
--	left join amount_constraint as ac on utn.notificationID = ac.notificationID
--	left join time_constraint as tc on utn.notificationID = tc.notificationID
--	left join location_constraint as lc on utn.notificationID = lc.notificationID
--	where utn.userID = @userID;
--GO

EXECUTE joinAllNotifs 'b48b3368-019a-4ef3-bcd7-2f9a425eaac7'
