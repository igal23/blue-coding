-	Please suggest an approach on how we can restrict developers from having access to sensitive information such as database passwords for production, etc.
	- Use Keyvault to store sensitive data

-	Define steps for a pipeline that will ensure our CI/CD process will guarantee that the project will retain its functionality and follow our code standards.
	- Configure pre-commit checks
	- Build the project Docker image
	- Run Unit Test
	- Run Integration Test
	- Deploy Image
	- Tag branch