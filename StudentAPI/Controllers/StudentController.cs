
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Models;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class StudentController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<StudentController> _logger;

    public StudentController(AppDbContext context, ILogger<StudentController> logger)
    {
        _context = context;
        _logger = logger;
    }

    // GET all students
    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        _logger.LogInformation("Fetching all students");

        var students = await _context.Students.ToListAsync();
        return Ok(students);
    }

    // POST add student
    [HttpPost]
    public async Task<IActionResult> AddStudent(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
        return Ok(student);
    }

    // PUT update student
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(int id, Student student)
    {
        var existing = await _context.Students.FindAsync(id);
        if (existing == null) return NotFound();

        existing.Name = student.Name;
        existing.Email = student.Email;
        existing.Age = student.Age;
        existing.Course = student.Course;

        await _context.SaveChangesAsync();
        return Ok(existing);
    }

    // DELETE student
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return NotFound();

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        return Ok("Deleted");
    }
}