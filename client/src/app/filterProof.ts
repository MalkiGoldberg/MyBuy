export interface FilterProof{
    idUser:string,
    kindOfPayment:number,
    action:number,
    category:number,
    chainStore:number,
    branch:number,
    beginDate:Date|'dd/mm/yy',
    endDate:Date,
    recycling:boolean
}