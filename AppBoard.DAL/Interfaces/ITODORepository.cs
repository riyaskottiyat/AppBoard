﻿using AppBoard.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBoard.DAL
{
    /// <summary>
    /// Interface ITODORepository
    /// Implements the <see cref="AppBoard.DAL.IRepository{AppBoard.Entity.ToDo}" />
    /// </summary>
    /// <seealso cref="AppBoard.DAL.IRepository{AppBoard.Entity.ToDo}" />
    public interface ITODORepository: IRepository<ToDo>
    {
        /// <summary>
        /// Gets my todos.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        /// <param name="today">The today.</param>
        /// <returns>IEnumerable&lt;ToDo&gt;.</returns>
        IEnumerable<ToDo> GetMyTODOS(int userId, bool? status, DateTime? today);
    }
}
