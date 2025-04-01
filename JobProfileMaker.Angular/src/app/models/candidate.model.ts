export interface Candidate{
    id : number;
    fullName : string;
    email : string;
    phoneNumber? : string;
    education : Education[];
    experience : Experience[];
    skills : Skills[];
}

export interface Education{
    degree : string;
    fieldOfStudy : string;
    university : string;
    startDate : Date;
    endDate? : Date;
    grade?:  string;
}

export interface Experience{
    company : string;
    jobTitle : string;
    startDate : Date;
    endDate? : Date;
    description? : string;
}

export interface Skills{
    skillName : string;
    yoe? : number;
}