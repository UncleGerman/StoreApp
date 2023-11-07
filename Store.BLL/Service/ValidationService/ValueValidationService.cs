namespace Store.BLL.Service.ValidationService
{
	internal sealed class ValueValidationService : IValueValidationService
    {
        public void CheckEntity(object? entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }

        public void CheckEntityId(int entityId)
        {
            if (entityId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(entityId));
            }
        }

        public void CheckEntityId(int entityId, int listCount)
        {
            if (entityId < listCount)
            {
                throw new ArgumentOutOfRangeException(nameof(entityId), "Entity Id must not be less than the current collection");
            }

            if (entityId > listCount)
            {
                throw new ArgumentOutOfRangeException(nameof(entityId), "Entity Id must not be greater than the current collection");
            }
        }
    }
}