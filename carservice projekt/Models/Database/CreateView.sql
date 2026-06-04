create view vw_wartungsübersicht
as
select
    f.Marke,
    f.Modell,
    s.Bezeichnung as Serviceart,

    w.Datum,
    w.Kosten,
    w.Status

from Wartungen w

inner join Fahrzeuge f

    on w.FahrzeugID = f.FahrzeugID

inner join Servicearten s
    on w.ServiceartID = s.ServiceartID;
go