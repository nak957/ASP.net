using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTQ_lab04._2.Models
{
    public class PTQ_Customer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
        public interface ICustomerRepository
        {
            //khai báo phương thức lấy danh sách khách hàng
            IList<PTQ_Customer> GetCustomers();
            //khai báo phương thức lấy khách hàng
            PTQ_Customer GetCustomer(string customerId);
            //khai báo phương thức thêm khách hàng
            void AddCustomer(PTQ_Customer cus);
            //khai báo phương thức cập nhật khách hàng
            void UpdateCustomer(PTQ_Customer cus);
            //khai báo phương thức tìm kiếm khách hàng
            IList<PTQ_Customer> SearchCustomer(string name);
            //khai báo phương thức xóa khách hàng
            void DeleteCustomer(PTQ_Customer cus);
        }
    }
    
}