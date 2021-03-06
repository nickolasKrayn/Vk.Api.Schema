﻿using Vk.Api.Schema.Enums.Poll;

namespace Vk.Api.Schema.Parameters.Poll
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для polls.deleteVote <para/>
    /// Документация: <see href="https://vk.com/dev/polls.deleteVote"/>
    /// </summary>
    public interface IPollDeleteVoteParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, которому принадлежит опрос
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор опроса
        /// </summary>
        int PollId { get; set; }

        /// <summary>
        /// Идентификатор варианта ответа
        /// </summary>
        int AnswerId { get; set; }

        /// <summary>
        /// Определяет находится ли опрос в обсуждении или прикреплён к стене
        /// </summary>
        PollBoardType Board { get; set; }
    }
}
