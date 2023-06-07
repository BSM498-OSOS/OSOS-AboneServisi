using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransformerManager : ITransformerService
    {
        private readonly ITransformerDal _transformerDal;

        public TransformerManager(ITransformerDal transformerDal)
        {
            _transformerDal = transformerDal;
        }

        public IResult Add(Transformer transformer)
        {
            _transformerDal.Add(transformer);
            return new SuccessResult();
        }

        public IResult Delete(Transformer transformer)
        {
            _transformerDal.Delete(transformer);
            return new SuccessResult();
        }

        public IDataResult<List<Transformer>> GetAll()
        {
            var result=_transformerDal.GetAll();
            if(result!=null)
                return new SuccessDataResult<List<Transformer>>(result);
            return new ErrorDataResult<List<Transformer>>();
        }

        public IDataResult<Transformer> GetById(Guid transformerId)
        {
            var result= _transformerDal.Get(b=>b.Id == transformerId);
            if (result != null)
                return new SuccessDataResult<Transformer>(result);
            return new ErrorDataResult<Transformer>();
        }

        public IResult Update(Transformer transformer)
        {
            _transformerDal.Update(transformer);
            return new SuccessResult();
        }
    }
}
