# Best_Price_Insurance
This repository is part of a personal project to create a car insurance website API in an MVC format.

#### -[About The Project](#Welcome_Page)

#### -[Admin Page](#Admin_Page)

#### -[Api Controller](#Api_Controller)

#### -[Home Controller](#Home_Controller)



# **Welcome_Page**

I decided to create a auto policy website that would take in information from a user and add it to a given database. Part of this project was to apply learned skills from a previous API project to a larger project and database.

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPwelcomePage.jpg)

When the user opens the page they are brought to the welcome screen and then brought to the web form that would take their information

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPpolicyForm.jpg)

When the user would input the information and submit they would be taken to a new page with their estimated new policy quote. The user information is also logged into the database.
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPpolicyFormWithData.jpg)

The ViewQuote page
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPviewQuote.jpg)

[Back To Top](#Web_Api_Demo)

# **Admin_Page**

The admin of the website could go to a private website not viewable to customers where the admin could query the database and remove client information.

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPhomeAdminUrl.jpg)

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPadminPage.jpg)

With the Search button located next to the input field, an admin could see how all client information or search for individual Id's unique to a clients account.

Here I logged the information to the console. In the first search there is no specified ID. 
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/initialAdminGetRequest.jpg)

In the second search an ID was specified.
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/adminGetRequestWithId.jpg)

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/adminGetRequestWithIdResult.jpg)

The remove button made it easy to delete multiple entries from the database. Here I had multiple entries so I used a DELETE Request to remove the selected data from the customers Database.

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/databaseMultiEntry.jpg)


I set the delete button to send a success alert to the page upon successful deletion of the account data

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/MultiEntryAdminPageDeleteSuccess.jpg)

After that I wanted to show that my api requests were able to target data that had been added to the database without refreshing the page. So in a seperate page I used the form again to add a new entry into the database.

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/NewDBEntry.jpg)

Once the entry was made I created a new get request to pull the new information from the database. At first I did not specify an Id so I could pull all of the account data. On the second request I specified an Id to use the overloaded get request

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/NewDBgetRequestsWithNewEntry.jpg)

Here you can see the new data added into my SQL database.

![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BestPriceDBinVS.jpg)

Here is my Admin page code where I created the account cards. I used Ajax, and jQuery to use the API requests on the page

input text field
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/adminTextSearchCode.jpg)

Remove button
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/adminRemoveButtonCode.jpg)

Admin Page jQuery and Ajax
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/AdminPageAjaxJqueryCode.jpg)





[Back To Top](#Best_Price_Insurance)

# **Api_Controller**

Here is the code for my API controller. For this project I only used Get requests and a Delete request. For the scope of this project I felt those are the only ones that I needed. In this project I used an entity framework controller on the api.

This is the code I used for my get requests
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/ApiControllerGetRequests.jpg)

This is the code I used for my Delete request
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/ApiControllerDeleteRequest.jpg)

In my routing config file I stuck with the default route. In the past i've used attribute routing but did not feel it to be necessary in this project.
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/ApiRouteFile.jpg)

[Back To Top](#Web_Api_Demo)

# **Home_Controller**

Inside of my Home Controller I wrote the logic that proccessed the form information and stored it into the database. This home controller also sent the data back out to the ViewQuote, and Admin pages.
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPHomeController.jpg)

Here is where the code was added to the database
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPHomeControllerSqlQueryCode.jpg)

and here is where the admin page logic was performed
![alt text](https://github.com/Tmc802/Best_Price_Insurance/blob/master/InsurancePolicyApi/BP%20insurance%20images/BPHomeControllerAdminPageLogic.jpg)

[Back To Top](#Web_Api_Demo)
