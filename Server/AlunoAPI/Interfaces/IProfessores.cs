﻿using AlunoAPI.Models;

namespace AlunoAPI.Interfaces
{
    public interface IProfessores
    {
        Task<IEnumerable<Professor>> GetProfessores();
        Task<Professor> GetProfessorById(int id);
        Task PostProfessor(Professor professor);
        Task PutProfessor(int id, Professor professor);
        Task DeleteProfessor(int id);
    }
}
