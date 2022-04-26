select * from InfoClients;

insert into Facture values('facebook','xxxxx','yyyyy',100,400,'04/15/2008',1500,'zzaa',7);


SELECT InfoClients.ICE , InfoClients.IFC , InfoClients.ClientId ,Facture.FactureN 
,Facture.Designation , Facture.Quantite ,Facture.Prix ,Facture.[Reference ]
FROM Facture
INNER JOIN InfoClients ON InfoClients.ClientId=Facture.[Client ID] AND 
Facture.RS='facebook'
;