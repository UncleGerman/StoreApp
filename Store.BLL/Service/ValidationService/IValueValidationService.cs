namespace Store.BLL.Service.ValidationService
{
	internal interface IValueValidationService
    {
        public void CheckEntity(object? entity);

        public void CheckEntityId(int entityId);

        public void CheckEntityId(int entityId, int listCount);
    }
}