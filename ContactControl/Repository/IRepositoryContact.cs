using ContactControl.Models;

namespace ContactControl.Repository
{
    public interface IRepositoryContact
    {

        ContactModel ListID(int id);


        List<ContactModel> GetAll();


        ContactModel Add(ContactModel contact);
    }
}
