using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slk.Data;
using Slk.Models;

namespace Slk.Services
{
    public class UserService : IUserService
    {
        public OperationResult Create(User user, string pass)
        {
            var res = OperationResult.CreateWithSuccess();

            using (var db = new SlkContext())
            {
                var usr = db.inf_user.FirstOrDefault(f => f.email == user.Email && f.record_state != 1);
                if (usr != null)
                    return OperationResult.CreateWithError("E-mail is busy");

                usr = new inf_user
                {
                    avatar = string.Empty,
                    email = user.Email,
                    first_name = user.FirstName,
                    last_name = user.LastName,
                    pass = pass,
                    creation_date = DateTime.UtcNow,
                    record_state = 0
                };

                db.inf_user.Add(usr);
                db.SaveChanges();

                user.Id = usr.id;
                res.Data.Add("user", user);
            }

            return res;
        }

        public OperationResult SignIn(string email, string pass)
        {
            var res = OperationResult.CreateWithSuccess();

            using (var db = new SlkContext())
            {
                var usr = db.inf_user.FirstOrDefault(f => f.email == email && f.record_state != 1);
                if (usr == null)
                    return OperationResult.CreateWithError("E-mail not found");
                if (usr.pass != pass)
                    return OperationResult.CreateWithError("Password do not match");

                var user = new User {
                    Id = usr.id,
                    Email = usr.email,
                    FirstName = usr.first_name,
                    LastName = usr.last_name,
                    CreationDate = usr.creation_date,
                    RecordState = (EnumRStates)usr.record_state
                };

                res.Data.Add("user", user);
            }

            return res;
        }
    }
}