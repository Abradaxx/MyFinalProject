using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }

    }
}
//şu Result kısmında ctorlarda kullandıgımız base yapısını bi araştır yabancı kaynaklardan