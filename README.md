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
1. Install Python into OS environment. Copy and paste virus_scan.py in Python folder into Python Lib root folder <br />
2. Create database by running commands in Package Manager: ADD-MIGRATION InitialDbCreation <br />
3. Update-database InitialDbCreation <br />
System uses <b>IdentityDbContext</b>, a trusted, battle hardened Authentication and Authorisation component. 
<img src="https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/POS_IMS.jpg">
<br />
<br />

Then in root folder of POS_IMS, run in CMD:
dotnet run.
<br />
<b>One and only one Super Administrator is created, this occurs when Update-database command is executed.<br />
System can have many Administrators. <br />

<b>Critical: Super admin and AI is created with default passwords.</b><br />
1. The email to these two accounts must be changed. Go to models/Config.cs and input the required genuine emails.
2. Open web browser to URL https://192.168.1.103:7184 and go to login and click forgot password link and change the default passwords. <br />
Credentials for super admin: username = SuperAdmin, Password = "defaultPassword1". <br />
Credentials for AI: username = SystemAI, Password = "defaultPassword2". <br />
Domain address can be changed by changing the applicationUrl in launchSettings.json, found in POS_IMS/Properties/launchSettings.json.<br />


<b>Trilio</b> is used to send emails and SMS. Email address validation and 2FA login must be changed. <br />
1. Go to POS_IMS/Models/Init.cs and change the requried credentials for SendGrid, Trilio, and GoogleMapsApi. <br />
2. <b>Critical:</b> Google address API key cannot be hidden being a frontend feature. Make sure it is a public key, restrict access to map js and domain address only.</b> <br />
Go to POS_IMS/wwwroot/js/autoaddress.js and change the Google Api key.
3. Go to POS_IMS/Views/Home/InitialContact.cshtml and change the API key at URL calling Google address API.
4. System uses CloudMersive to scan files for malware. Api key needed. 
<img src="https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/register.jpg">
<br />
<img src="https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/confirmEmail.jpg">
<br />
<img src="https://github.com/kiet1375/POS_IMS/blob/main/POS_IMS/POS_IMS/imgs/sms.jpg" width="400" height="790">
<br />

Technical and User documentation for Authentication and Authorisation will be available when component has been fully rolled out. <br /><br />
IMS construction will begin after POS construction has been completed.





