using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.Rewards.Data;
public interface IUnitOfWork
{
    // IRewardRepository RewardRepository { get; }
    // IUserRepository UserRepository { get; }
    // IPostRepository PostRepository { get; }
    // IRecognitionRepository RecognitionRepository { get; }
    // INominationRepository NominationRepository { get; }
    // IUserRecognitionRepository UserRecognitionRepository { get; }
    // ITeamRepository TeamRepository { get; }
    // IUserTeamRepository UserTeamRepository { get; }
    // IUserRewardRepository UserRewardRepository { get; }
    // ILikeRepository LikeRepository { get; }
    // ICommentRepository CommentRepository { get; }
    void BeginTransaction();
    void CommitTransaction();
    void RollBackTransaction();
    void Save();
}
