# EmpDirForms

This project demonstrates simple integration between IBM MobileFirst Platform and Xamarin.

![Screen Images](https://github.com/srhallx/EmpDirForms/blob/master/EmployeeScreen1.png "Employee List")
![Screen Images](https://github.com/srhallx/EmpDirForms/blob/master/EmployeeScreen2.png "Employee Detail")

## Solution Architecture
This project requires the IBM MobileFirst Platform, with the project in the EmployeeDirectory directory deployed to it. Copy this directory to your MobileFirst Platform apps directory, build and deploy through [MFP CLI](https://developer.ibm.com/mobilefirstplatform/documentation/getting-started-7-0/advanced-client-side-development/using-cli-create-build-manage-project-artifacts/#export).

## Data source
The data source for this application is a Cloudant no-SQL database.  I've made a small datasource public so you can try this app without creating your own. However, if you would like to edit the database contents, create your own Cloudant data source and modify the EmployeeAdapter.xml file with the new location of the database.  If your record sets have a different name, you'll also need to modify EmployeeAdapter-impl.js accordingly.

## Mobile App Architecture
EmpDirForms uses Xamarin.Forms with a shared common-code project.  All of the UI and IBM integration code is in the shared project.  There is a small amount of code in the iOS and Android specific projects, in AppDelegate.cs and MainActivity.cs respectively.

## Android

In order to run this project on Android (device or simulator), you'll need a Google Maps API Key.  Instructions are [here] (https://developer.xamarin.com/guides/android/platform_features/maps_and_location/maps/obtaining_a_google_maps_api_key/).

Your maps key must be inserted in the AndroidManifest.xml file in the Properties directory of the Android project.

```
<application android:label="Employees">
		<meta-data android:name="com.google.android.geo.API_KEY" android:value="[YOUR KEY HERE]" />
</application>
```
