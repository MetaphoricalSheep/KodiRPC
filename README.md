# KodiRPC

## Setting up a new Config

1. Open the ```Configuration Manager``` and create a new configuration.
2. Create a copy the Base.config file in KodiRPC/demo and name it to the same name you used for the new configuration.
3. Open up the config file in an editor. Add ```xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform"``` to the configuration     element and ``` xdt:Transform="SetAttributes" xdt:Locator="Match(key)"``` to all the appSettings children:

   ```xml
   <?xml version="1.0" encoding="utf-8" ?>
   <configuration xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform">
     ...
     <appSettings>
       <add key="KodiUsername" value="kodi" xdt:Transform="SetAttributes" xdt:Locator="Match(key)"/>
       ...
       <add key="KodiPort" value="80" xdt:Transform="SetAttributes" xdt:Locator="Match(key)"/>
     </appSettings>
   </configuration>
   ```
   
4. Change all the values to what you need it to be for the new configuration. You can remove anything that does not have to change.
5. Select the new configuration from the Configuration Manager and click build. App.config should now transform with the values in the new config file.
6. Add the new config file to .gitignore
