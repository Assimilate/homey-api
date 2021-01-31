# Homey

This project should run together with [Homey-App](https://github.com/Assimilate/homey-app)

## Backlog

- Unit tests.

- JWT Authentication.

- Could add more type of measurements like humidity, energy consumption etc...

## Notes

- The endpoint is /houses/:id/data instead of /homes/:id/data

- The database is Sqlite and all important migrations and updates are made automatically upon `dotnet watch run`.

## How to run

1. Make sure you have installed .NET Core 5.0 before proceeding with the next steps.

2. Pull this repository to a file on your machine.

3. Navigate into that file and then navigate into /homey-api.

4. Run `dotnet watch run` to start the API. Navigate to `https://localhost:5001/`.

5. Make sure you allow the https certificate by clicking`continue to localhost anyway`.

6. The API is now ready to communicate with the app; see [Homey-App](https://github.com/Assimilate/homey-app).
