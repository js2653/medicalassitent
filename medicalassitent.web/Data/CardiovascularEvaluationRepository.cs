namespace medicalassitent.web.Data
{
    using Entities;

    public class CardiovascularEvaluationRepository : GenericRepository<CardiovascularEvaluation>, ICardiovascularEvaluationRepository
    {
        public CardiovascularEvaluationRepository(DataContext context) : base(context)
        {
        }
    }
}
