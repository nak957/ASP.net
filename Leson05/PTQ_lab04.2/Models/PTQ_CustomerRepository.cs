using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTQ_lab04._2.Models
{
    public class PTQ_CustomerRepository
    {
        static readonly List<PTQ_Customer> data = new List<PTQ_Customer>()
        {
            new PTQ_Customer(){ CustomerId = "KH001",
                FullName = "Phạm Thế Quyền",
                Address = "Ân Thi",Email = "phamthequyen1411@gmail.com",
                Phone = "0968364242",Balance = 15200000},
            new PTQ_Customer(){ CustomerId = "KH002",
                FullName = "Đường Huyền Trang",
                Address = "Đông thổ Đại đường",Email = "duongtam@gmail.com",
                Phone = "0986.767.444",Balance = 2200000},
            new PTQ_Customer(){ CustomerId = "KH003",
                FullName = "Tôn Ngộ Không",
                Address = "Hoa quả sơn",Email = "ngukhu@gmail.com",
                Phone = "0924.656.542",Balance = 1200000},
            new PTQ_Customer(){ CustomerId = "KH004",
                FullName = "Trư Bát giới",
                Address = "Cao Lão Trang",Email = "Thienbongn@gmail.com",
                Phone = "0996.555.267",Balance = 6200000 }
        };
        public IList<PTQ_Customer> GetCustomers()
        {
            return data;
        }
        //thực thi phương thức tìm khách hàng theo tên
        public IList<PTQ_Customer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        //thực thi phương thức lấy khách hàng theo Id
        public PTQ_Customer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }
        public void PTQ_AddCustomer(PTQ_Customer cus)
        {
            data.Add(cus);
        }
        //thực thi phương thức cập nhật khách hàng
        public void PTQ_UpdateCustomer(PTQ_Customer cus)
        {
            //lấy khách hàng theo id
            var customer = data.FirstOrDefault(c =>
            c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }
        public void PTQ_DeleteCustomer(PTQ_Customer cus)
        {
            data.Remove(cus);
        }
    }
}