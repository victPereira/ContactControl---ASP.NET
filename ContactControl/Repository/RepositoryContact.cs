using ContactControl.Data;
using ContactControl.Models;

namespace ContactControl.Repository
{
    public class RepositoryContact : IRepositoryContact
    {

        private readonly BaseContext _basecontext;


        public RepositoryContact(BaseContext baseContext)
        {
            this._basecontext = baseContext;
        }

        public ContactModel ListID(int id)
        {
            return _basecontext.Contacts.FirstOrDefault(x => x.Id == id);
        }


        // Listando itens do banco de dados
        public List<ContactModel> GetAll()
        {
            return _basecontext.Contacts.ToList();
        }



        // Adicionar dados no banco
        public ContactModel Add(ContactModel contact)
        {
            _basecontext.Contacts.Add(contact);
            _basecontext.SaveChanges();
            return contact;
        }

        
    }
}
