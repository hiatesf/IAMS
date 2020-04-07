-- Instrument List select * from mr001
--select * from u0000 
--select * from mr000
select mr000.Name, u0000.StreetNameYH, u0000.PlaceBuildingYH, u0000.CountryYH, u0000.TelephoneYH, u0000.ContactPersonYH from mr000 join u0000 on mr000.MasterId=u0000.ExtraId


