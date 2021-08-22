
### Simple File Uploader with Angular 

This is frontend application of the home task for the company Flying Donkey. 

The following tasks are done:

[x] File size and file types that can be uploaded to the server must be configurable. Validation for invalid data should present.

[ ] Add at least two unit tests for the back-end. Tests must have positive and negative scenarios. Default tests added by angular cli will be ignored during the task evaluation.

[x] API must have layered architecture, code must follow common style guides and development principles.

[x] File size and file types that can be uploaded to the server must be configurable. Validation for invalid data should present.

[x] Feel free to choose any storage for uploaded files (it can be DB/File System/etc.) The only requirement here - storage must be persistent during runtime

[ ] File download/preview is not required but would be good if implemented.


### Setup

- Clone the repo by typing
- Open the project in Visual Studio, possibly 2019 version. (On MacOS VIsual Studio Code will be also fine if you add several C# and .Net extensions for VSCode). 
- Make sure you have `SQL Server 2019` installed and started in your local machine.
- Run `Update-Database` in Package Manager Console. (On MacOS, you must install `dotnet` and `dotnet ef` then you can type `dotnet ef database update` in the terminal). This will create SQLite database , namely `FlyingDonkeyTaskRamin`, and will locate it in you project folder. 
- Run the app by using Start Debugging button in Visual Studio. (On MacOS, you will type `dotnet watch run`)
- Open `https://localhost:5001/api/fileItems` in your browser to be sure that the API is working right.
- The frontend application which will make use of the data that this API provides, can be downloaded from [this repository](https://github.com/RaminMammadzada/file-upload-angular-client)

## Built with the following tech stack

- [.Net Core](https://dotnet.microsoft.com/download)
- [Entity Framework](https://docs.microsoft.com/en-us/ef/)

## Author

👤 **Ramin Mammadzada**

- Github: [@raminmammadzada](https://github.com/raminmammadzada)
- Twitter: [@raminmammadzada](https://twitter.com/raminmammadzada)
- Linkedin: [Ramin Mammadzada](https://www.linkedin.com/in/raminmammadzada/)




