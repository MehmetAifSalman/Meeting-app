namespace MeetingApp.Models
{
    public static class Repository{

        private static List<UserInfo> _users = new();

        static Repository(){
            _users.Add(new UserInfo(){Id = 1,Name = "Ali" , Email = "asdsa@gmail.com" , Phone = "11111" , willatend = true});
            _users.Add(new UserInfo(){Id = 2, Name = "Ayşe" , Email = "asdsa@gmail.com" , Phone = "22222" , willatend = true});
            _users.Add(new UserInfo(){Id = 3,Name = "Narin" , Email = "asdsa@gmail.com" , Phone = "33333" , willatend = false});
        }

        public static  List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo GetbyId(int id){
            return _users.FirstOrDefault(user => user.Id == id);
        }
        
    }
}