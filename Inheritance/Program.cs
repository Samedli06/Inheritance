using Inheritance;

Admin admin1 = new Admin("Ali", "Aliyev", "jshdbkbd@gmail.com", "232938213",UserRole.Admin);

ProfileController profileController = new ProfileController();

User user1 = new User("Bakhtiyar" , "Samadli" , "crazyboy777@gmail.com" , "3123" , UserRole.User, 18);

profileController.signup("Bakhtiyar", "Samadli", "sjdkdsb@gmail.com", "23132421", UserRole.Admin);

profileController.signin("sjdkdsb@gmail.com", "23132421");

profileController.showProfile(user1);

