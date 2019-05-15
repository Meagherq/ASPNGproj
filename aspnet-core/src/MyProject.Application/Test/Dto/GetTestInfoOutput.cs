using MyProject.Users.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test.Dto
{
    public class GetTestInfoOutput
    {
        public UserDto User { get; set; }
        public TestInfoDto Test { get; set; }
    }
}
