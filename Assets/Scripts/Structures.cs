public struct Topic
{
    InterestLevel interest;
    KnowledgeLevel knowledge;
}

public struct TopicList
{
    Topic videoGames;
    Topic sports;
    Topic academics;
    Topic moviesTV;
    Topic celebrities;
}


public enum InterestLevel
{
    AGAINST, NEUTRAL, MILD, INTERESTED, DESIRED
}

public enum KnowledgeLevel
{
    AGAINST, LITTLE, AVERAGE, PROFICIENT, EXPERTISE
}