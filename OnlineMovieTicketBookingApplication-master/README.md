# OnlineMovieTicketBookingApplication

Models - CinemaContext, Admin, User, Customer, CustomerViewModel, Movie, Show, Hall, Ticket (not created yet), Booking (not created yet)


Views:

Admin Login -> login page for admins (completed)

Admin Index -> main menu for admin (incomplete)


Home Index -> home page for users (incomplete - yet to display movies)


Movie Create -> add movies for admins (incomplete - file upload)

Movie Delete -> delete movies for admins (complete)

Movie Details -> view movie details for users (incomplete - yet to add showtimes at the bottom of page for booking)

Movie Edit -> edit movie details for admins (incomplete - error and file upload)

Movie Index -> view movies for users (complete)

Movie List -> movie index for admins (complete)


Shared _NowShowing -> display now showing movies in movie details page (complete)

Shared _ComingSoon -> display coming soon movies in movie details page (complete)

Shared _Layout -> navigation layout for users (incomplete - change login and register to logout after user sign in)

Shared _AdminLayout -> side bar navigation layout for admin (incomplete - manage bookings link, and logout)


Show Create -> create show times for admins (complete)

Show Delete -> delete show times for admins (complete)

Show Edit ->  edit show times for admins (complete)

Show Index -> show times index for admins (complete)


User Login -> user login (complete)

User Register -> (complete)


Tasks:
- create userRepo and move the business logic (login and register) in user controller to userRepo
- change login and register to profile and logout upon login -> Link send by G3: https://www.c-sharpcorner.com/article/asp-net-core-razor-pages-simple-login-using-entity-framework-database-first-app/
- add profile and logout action methods 
- create AdminRepo and move business logic (login) in admin controller to AdminRepo
- add logout action method for admin, and logout in _AdminLayout View
- modify the create and edit action methods for MovieController/MovieRepo to fix error for file upload
- [Kaiyan] add showtimes to movie details view, create buttons for each show time that links to booking 
- create Ticket Model, Ticket Controller, Ticket Repo and respective Views
- create Booking Model, Booking Controller, Booking Repo and respective Views




