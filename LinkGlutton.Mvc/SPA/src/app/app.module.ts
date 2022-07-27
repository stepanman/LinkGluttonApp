import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LinkComponent } from './components/link/link.component';
import { LinklistComponent } from './components/linklist/linklist.component';

@NgModule({
  declarations: [
    AppComponent,
    LinkComponent,
    LinklistComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
