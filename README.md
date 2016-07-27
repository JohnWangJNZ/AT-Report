# AT-Report
#ATNZ Project Proposal

#Introduction
This is a start-up project to produce statistical report of GTFS information, provided by Auckland Transport. The project features an ASP.NET MVC app and Auckland Transport (AT) API.

#Objective
The goal of the app is constantly collecting data from AT, and utilize these data to produce statistical report. The report contains written description, charts and potentially other data representations.

#Technologies
The following table shows all essential technologies applied to build the app.
Framework	.NET, MVC
Languages	C#, ASP.NET, HTML, CSS, Javascript
Libraries	JQuery, Bootstrap, AT API

#App Specification
The following table shows the basic specification of the app.
#Front-End Pages
	-Index with optional admin login
-(Multiple pages) (Removable by admin) Local data with pagedlist
-(Multiple pages) Report Customization
-(Admin) Data retrieval customization 
Front-End Style Files	-Original bootstrap
-Original primary theme
-Customized theme
#Back-End	-Based on preset structure of MVC app
-AT folder collecting universal AT API functions
-LIB folder collecting other universal functions
*universal function means an unchanged function used by multiple classes
#Database Tables	-Parking
-Stop
-Route
-Customer Service Centre
-Calendar
-Agency
-Scheduled Work
*only static data are stored at the moment
*Scheduled work means planned road work

#Functional Requirements
Front-End:
-Display site navigation links
-Categorize and display data from database
-Display report customization options
-Export report in one or multiple file formats
-Display admin data retrieval customization options

#Back-End:
-Codes corresponding to links
-Retrieving data from AT server and insert into local database
-Setup data retrieval schedule
-Managing local database
-Setup algorithms for statistical purpose
-Creating charts
-Add charts to report and export in various formats

#Optional:
-Display report on web page
-Display real-time information on web page

Non-Functional Requirements
Web hosting and patching:
-Utilizing Azure server and GitHub

#Coding practice
-The application is using code-first approach
-Web control naming abcDefGhi (name of control type) + AbcDefGhi (actual control name)
-Style/CSS naming standard strictly refers to primary theme
-Back-end naming standard strictly refers to the style of MSDN resources
