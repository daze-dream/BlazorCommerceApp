use commerceapp


select * from userToNotifications
delete from userToNotifications where notificationID = 40;
select * from userToNotifications
 LEFT JOIN 
amount_constraint on userToNotifications.notificationID = amount_constraint.notificationID
LEFT JOIN time_constraint on userToNotifications.notificationID = time_constraint.notificationID
LEFT JOIN location_constraint on userToNotifications.notificationID = location_constraint.notificationID

select * from time_constraint
select * from location_constraint
select * from amount_constraint


delete from userToNotifications where notificationID = 1;
delete from location_constraint where notificationID = 1;
select * from userToNotifications
insert into location_constraint values (1, 'Target');