using Business.Abstract;
using Castle.Core.Resource;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            var result = _customerDal.Get(c => c.Id == customer.Id);
            if(result != null)
            {
                _customerDal.Delete(result);
                return new SuccessResult();
            }
            return new ErrorResult();
            
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var result = _customerDal.GetAll();
            if(result.Count>0)
                return new SuccessDataResult<List<Customer>>(result);
            return new ErrorDataResult<List<Customer>>();
        }

        public IDataResult<Customer> GetById(Guid customerId)
        {
            var result=_customerDal.Get(m => m.Id == customerId);
            if(result!=null)
                return new SuccessDataResult<Customer>(result);
            return new ErrorDataResult<Customer>();
        }

        public IDataResult<Customer> GetByMeterId(int meterId)
        {
            var result = _customerDal.Get(m => m.MeterId == meterId);
            if (result != null)
                return new SuccessDataResult<Customer>(result);
            return new ErrorDataResult<Customer>();
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }

    }
}
