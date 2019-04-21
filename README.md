# driving-school
Application Development final project

1.Driving school project build with C# and Monodevelop
unnecesary line added in chiwa house

2.Tryng to add a image in window crashes monodevelop on Javier's Pc.

TODO:

1. Vehicle state shows as integer, system should be build where the combobox shows:

Active

Inactive

Broken

but the query to the database should use integers , representing the states stated above. 

2. In user security there are fields in the table that cannot be accesed through the forms , start date , pwd_temp and state.
   start date should be the date that the user is created , the other two should be accesible by the form. 


3. In Client and vehicle start_date and final_date are accesible in the forms this shouldn't happen start date should be the date that the user is created and final_date should be the last date that the user was modified.

4. In course Instance the user should only be capable of creating a course if the vehicle is not in use and the instructor is not busy at the time the user selects in the curse. 


WARNINGS:

1. State field in course_service is static, combobox doesn't return right value.
