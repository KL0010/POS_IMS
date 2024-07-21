<h3><b>Application Under construction: Utilising Code First Approach</b></h3>
<b>Point of Sale (POS) and Inventory Management System (IMS)</b> is a .NET 8.0 Core MVC and Desktop application..NET Core is chosen due to its open source nature and is maintained by Microsoft. </b> <br />
AI/ML is used for regression analysis in customer behaviour predictions.
<br/>
Blockchain technology is used for smart contracts and to protect assets ownership.
<h4>System is designed for producers of blended products to keep track of Blends and Ingredients.</h4>
Documentation will be available after basic functionalities are rolled out.</br />
<br />
Tron network is used for smart contracts and validation of assets ownership.
<h3>Environment:</h3>

(1) .NET 8 Core
<br />
(2) NodeJs
<br />
(3) MS SQL 2023
<br />
(4) Python for AI/ML
<br />
(5) Tron network
<br />
<br />
<h3>To-Do:</h3>

Initial creation of database by running command in Package Manager: Update-database InitialDbCreation <br />
System uses <b>IdentityDbContext</b>, a trusted, battle hardened Authentication and Authorisation component. 
![alt ](https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/POS_IMS.jpg)
<br />
Then in root folder of POS_IMS, run in CMD:
dotnet run.
<br /> 
Open web browser to URL https://192.168.1.103:7184.<br />
Domain address can be changed by changing the applicationUrl in launchSettings.json, found in POS_IMS/Properties/launchSettings.json.<br />
<b>One and only one Super Administrator is created on first entry to AspNetUserRoles table</b>, which is triggered when first user is created.<br />
System can have many Administrators. <br />

<b>Trilio</b> is used to send emails and SMS. Email address validation and 2FA login must be changed. <br />
1. Go to POS_IMS/Models/EmailHelper and change SendGrid API key (line 13). Then change the email address (line 15). <br />
2. Go to POS_IMS/Areas/Account/Login.cshtml and change Trilio init to your Trilio credentials. <br />
3. Go to POS_IMS/Areas/Account/LoginWith2fa.cshtml and change init values your Trilio credentials. <br /><br />
The system sends two 2FA messages. One when user logs in to send the token values, and the other on deletion of the token. <br /><br />

<b>Note: Password change hasn't been implemented yet. </b> <br />
<b>Critical</b> to input an email and mobile you can access. Login cannot occur if email has not been validated, and pass 2fa logic. Example is shown below. <br />
<img src="https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/register.jpg">
<br />
<img src="https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/sms.jpg" width="400" height="790">
<br />

Technical and User documentation for Authentication and Authorisation will be available after the 31/7/2024, when component has been fully rolled out. <br /><br />
IMS construction will begin after POS construction has been completed.





