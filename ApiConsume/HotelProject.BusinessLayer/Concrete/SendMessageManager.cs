using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : GenericManager<SendMessage>, ISendMessageService
    {
        public SendMessageManager(IGenericDal<SendMessage> genericDal) : base(genericDal)
        {
        }

        public int TGetSendMessageCount()
        {
            return GetAll().Count;
        }
    }
}
