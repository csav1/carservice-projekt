create procedure sp_WartungenNachStatus
    @Status varchar(20)
as 
begin
    select *
    from Wartungen
    where status = @Status;
end;
go