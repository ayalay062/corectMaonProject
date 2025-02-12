import { Component, OnInit } from '@angular/core';
import { Kids } from '../classes/Kids';
import { TypeClass } from '../classes/TypeClass';

import { KidsService } from '../services/kid.service';
import { TypeClassService } from '../services/type-class.service';

@Component({
  selector: 'app-add-child',
  templateUrl: './add-child.component.html',
  styleUrls: ['./add-child.component.scss']
})

export class AddChildComponent implements OnInit {
  myKids: Kids ;
  listTypeClass: TypeClass[]
  constructor(private KidsSer: KidsService, private classTypeSer: TypeClassService) { }


  ngOnInit(): void {
    this.classTypeSer.getAllׁׂׂׂׂׂׂ().subscribe(
      data =>{ this.listTypeClass=data,
      console.log(this.listTypeClass)}
      
    )
  }

  addKids() {
    //delete
    //זה מילוי נוכחות וזה לא קשור לטופס הזה אז מה עושים
    this.myKids.kidId  = 0;
    // this.myKids.ageKids  = 0;
    // this.myKids.dateBorn  = new Date();

    this.myKids.classId = 1;

    console.log(this.myKids);
    debugger
    this.KidsSer.add(this.myKids).subscribe(
      data => console.log(data),
      err => console.log(err)



    )


  }

}
