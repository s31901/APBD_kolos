using APBD_kolos.Data;

namespace APBD_kolos.Services;

public class DbService : IDbService
{
    private readonly AppDbContext _dbContext;
    public DbService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    /*
     *public async Task<PcDto> AddPcAsync(AddPcsDto addPcsDto)
       {
           var pc = new Pc()
           {
               Name = addPcsDto.Name,
               Weight = addPcsDto.Weight,
               Warranty = addPcsDto.Warranty,
               CreatedAt = addPcsDto.CreatedAt,
               Stock = addPcsDto.Stock
           };
           await  _dbContext.Pcs.AddAsync(pc);
           await  _dbContext.SaveChangesAsync();
           
           return new PcDto
           {
               Id = pc.Id,
               Name = pc.Name,
               Weight = pc.Weight,
               Warranty = pc.Warranty,
               CreatedAt = pc.CreatedAt,
               Stock = pc.Stock
           };
       }
     * 
     */
}