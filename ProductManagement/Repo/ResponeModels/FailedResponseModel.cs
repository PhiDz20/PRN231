using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ResponeModels
{
    public class FailedResponseModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
