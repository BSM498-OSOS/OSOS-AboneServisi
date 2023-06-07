using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransformerService
    {
        IResult Add(Transformer transformer);
        IResult Delete(Transformer transformer);
        IResult Update(Transformer transformer);
        IDataResult<Transformer> GetById(Guid transformerId);
        IDataResult<List<Transformer>> GetAll();
    }
}
