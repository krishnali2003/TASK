using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Authorize]
[ApiController]
[Route("api/companies")] // Added "api/" for consistency
public class CompanyController : ControllerBase
{
    private static readonly List<Company> Companies = new()
    {
        new Company
        {
            CompanyName = "ABC Trading Co.",
            CompanyAddress = "123 Market Street, New York, NY, 10001",
            CompanyGSTN = "22AAAAA0000A1Z5",
            CompanyCode = "ABC12345",
            CompanyUserId = "abc_user_001",
            CompanyStatus = "active",
            CompanyStartDate = DateTime.Parse("2025-01-05T10:00:00Z"),
            CompanyNatureOfWork = "IT"
        }
    };

    // Create a new company
    [HttpPost]
    public IActionResult CreateCompany([FromBody] Company company)
    {
        if (Companies.Any(c => c.CompanyCode == company.CompanyCode))
            return Conflict("Company already exists.");

        Companies.Add(company);
        return CreatedAtAction(nameof(GetByCode), new { companyCode = company.CompanyCode }, company);
    }

    // Get all companies
    [HttpGet]
    public IActionResult GetAll() => Ok(Companies);

    // Get a company by code
    [HttpGet("{companyCode}")]
    public IActionResult GetByCode(string companyCode)
    {
        var company = Companies.FirstOrDefault(c => c.CompanyCode == companyCode);
        return company == null ? NotFound("Company not found.") : Ok(company);
    }

    // Update company details
    [HttpPut("{companyCode}")]
    public IActionResult Update(string companyCode, [FromBody] Company updatedCompany)
    {
        var company = Companies.FirstOrDefault(c => c.CompanyCode == companyCode);
        if (company == null) return NotFound("Company not found.");

        company.CompanyName = updatedCompany.CompanyName;
        company.CompanyAddress = updatedCompany.CompanyAddress;
        company.CompanyGSTN = updatedCompany.CompanyGSTN;
        company.CompanyUserId = updatedCompany.CompanyUserId;
        company.CompanyStatus = updatedCompany.CompanyStatus;
        company.CompanyStartDate = updatedCompany.CompanyStartDate;
        company.CompanyNatureOfWork = updatedCompany.CompanyNatureOfWork;

        return Ok(company);
    }

    // Delete a company
    [HttpDelete("{companyCode}")]
    public IActionResult Delete(string companyCode)
    {
        var company = Companies.FirstOrDefault(c => c.CompanyCode == companyCode);
        if (company == null) return NotFound("Company not found.");

        Companies.Remove(company);
        return NoContent();
    }
}

// Company Model
public class Company
{
    public string CompanyName { get; set; }
    public string CompanyAddress { get; set; }
    public string CompanyGSTN { get; set; }
    public string CompanyCode { get; set; }
    public string CompanyUserId { get; set; }
    public string CompanyStatus { get; set; }
    public DateTime CompanyStartDate { get; set; }
    public string CompanyNatureOfWork { get; set; }
}
