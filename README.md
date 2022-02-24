# Ecommerce-Web-App 
 step one: to run the project you will either download visual studio or vs code.
 
  ---------------------------------------------------- SHOULD YOU CHOOSE VS CODE -------------------------------------------------------
    
    MAKE SURE YOUR COMPUTER IS CONFIGURED TO RUN .NET CORE PROJECTS   
    
  ---------------- ----------------------------------------------------------------
 
 step two: download mssql 
 
 step three : open API then open appsettings :- on DefaultConnetion :  change the values of *** to your own database connection values
 
 step four: you will need to create migration 
 
 ---------------------------- VISUAL STUDIO ---------------------------------------
 
 on visual studio IDE : click tools then Nuget Package Manager then Package Manager Console 

 on the package manager console window  :- on Default Project select Infrastructure
 
 copy paste code on console :- add-migration initialCreate
 
 once migration is done 
 
 copy paste code on console :- update-database 
 
 once its done 
 
 run the project 
 
 --------------------------- VS CODE --------------------------------------------
 
 on vs code Terminal copy paste code :- dotnet ef migrations initialCreate --project Infrastructure
 
 once migration is done 
 
 copy paste code on Terminal := update-database 
 
 once its done 
 
 copy paste code:- dotnet watch run 



![electro00](https://user-images.githubusercontent.com/39485154/155523598-ae4649a0-ea4a-438f-935e-1c02efc9346d.PNG)
![ecom01](https://user-images.githubusercontent.com/39485154/155523626-0efb63b3-33d7-4595-aa2b-77d8b8b3e289.PNG)
![ecom02](https://user-images.githubusercontent.com/39485154/155523637-973817d3-1329-4859-ad4d-edcc302d7a30.PNG)
