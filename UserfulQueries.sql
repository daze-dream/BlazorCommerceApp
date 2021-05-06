use commerceapp


select * from userToNotifications
delete from userToNotifications where notificationID = 40;
select * from userToNotifications
 LEFT JOIN 
amount_constraint on userToNotifications.notificationID = amount_constraint.notificationID
LEFT JOIN time_constraint on userToNotifications.notificationID = time_constraint.notificationID
LEFT JOIN location_constraint on userToNotifications.notificationID = location_constraint.notificationID

select  utn.userID, utn.notificationID as ID, 
	coalesce(  CAST(ac.min as varchar), CONVERT(varchar(15),CAST(tc.time_in AS TIME),100), 'Matches') as Parameter1, 
	coalesce( CAST(ac.max as varchar), CONVERT(varchar(15),CAST(tc.time_out AS TIME),100) , lc.location) as Parameter2, 
	Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec 
	from userToNotifications as utn 
	left join amount_constraint as ac on utn.notificationID = ac.notificationID
	left join time_constraint as tc on utn.notificationID = tc.notificationID
	left join location_constraint as lc on utn.notificationID = lc.notificationID
	where utn.userID = '88dbfba3-2ee4-4ffd-85df-c4169f9bd800'

select notificationID, CONVERT(varchar(15),CAST(time_in AS TIME),100) from time_constraint

select * from time_constraint
select * from location_constraint
select * from amount_constraint
select * from triggeredNotif


delete from userToNotifications where notificationID = 1;
delete from location_constraint where notificationID = 1;
select * from userToNotifications
insert into location_constraint values (1, 'Target');

USE commerceapp
Go
CREATE PROCEDURE joinAllNotifs
	@userID nvarchar(450)
AS
	select  utn.userID, utn.notificationID as ID, 
	coalesce(  CAST(ac.min as varchar), CONVERT(varchar(15),CAST(tc.time_in AS TIME),100), 'Matches') as Parameter1, 
	coalesce( CAST(ac.max as varchar), CONVERT(varchar(15),CAST(tc.time_out AS TIME),100) , lc.location) as Parameter2, 
	Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec 
	from userToNotifications as utn 
	left join amount_constraint as ac on utn.notificationID = ac.notificationID
	left join time_constraint as tc on utn.notificationID = tc.notificationID
	left join location_constraint as lc on utn.notificationID = lc.notificationID
	where utn.userID = @userID;
GO

EXECUTE joinAllNotifs '88dbfba3-2ee4-4ffd-85df-c4169f9bd800'