using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Geometry.Server.Common.Models
{
    public class BaseMindBoxResponse
    {
        public bool IsSuccess { get; private set; }
        public string Message {get; private set;}

        public BaseMindBoxResponse(bool isSuccess = true, string message = "")
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public BaseMindBoxResponse() : this(true)
        {
        }
    }

    public class MindBoxResponse<T> : BaseMindBoxResponse
    {
        public T _data { get; private set; }

        public MindBoxResponse(bool isSuccess, string message) : base(isSuccess, message)
        {
        }

        public MindBoxResponse(T data, bool isSuccess = true, string message = "")
        {
            _data = data;
        }

        public MindBoxResponse() : this(default)
        {
        }
    }
}
