Create procedure [dbo].[AddNewRessource]  
(  
   @Code nvarchar (50),  
   @DateLiv nvarchar (50),  
   @DureeGarantie nvarchar (100),
   @Type nvarchar (50), 
   @Etat nvarchar (100)
)  
as  
begin  
   Insert into Ressources values(@Code,@DateLiv,@DureeGarantie,@Type,@Etat)  
End