# MauiPOC

Built by the MVVM pattern (<https://docs.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm>)

## To build Android

run ```dotnet build -t:Run -f net6.0-android``` on command line

## To build iOS

(this is on iPhone 11 Pro)
run ```dotnet build -t:Run -f net6.0-ios -p:_DeviceName=:v2:udid:FDE625D2-7326-497A-B16B-B85C7D32AFF8```

To see list of iOS simulator UDIDs:
run ```/Applications/Xcode.app/Contents/Developer/usr/bin/simctl list```