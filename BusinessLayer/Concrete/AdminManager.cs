using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AdminManager : IAdminService
	{
		IAdminDal _AdminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_AdminDal = adminDal;
		}

		public void Delete(Admin t)
		{
			_AdminDal.Delete(t);
		}

		public Admin GetById(int id)
		{
			return _AdminDal.GetById(id);
		}

		public List<Admin> GetListAll()
		{
			return _AdminDal.GetListAll();
		}

		public void Insert(Admin t)
		{
			_AdminDal.Insert(t);
		}

		public void Update(Admin t)
		{
			_AdminDal.Update(t);
		}
	}
}
