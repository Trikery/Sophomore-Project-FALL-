(function (lib, img, cjs, ss) {

var p; // shortcut to reference prototypes
lib.webFontTxtInst = {}; 
var loadedTypekitCount = 0;
var loadedGoogleCount = 0;
var gFontsUpdateCacheList = [];
var tFontsUpdateCacheList = [];

// library properties:
lib.properties = {
	width: 2560,
	height: 1440,
	fps: 12,
	color: "#FFFFFF",
	opacity: 1.00,
	webfonts: {},
	manifest: [
		{src:"images/rabbit_atlas_.png", id:"rabbit_atlas_"}
	]
};



lib.ssMetadata = [
		{name:"rabbit_atlas_", frames: [[2564,1444,675,891],[3241,1444,622,543],[3846,1142,187,122],[886,2166,334,473],[3241,1989,573,492],[1222,2166,365,382],[3846,685,158,252],[3816,1989,199,114],[3846,1266,199,114],[1589,2166,364,252],[443,2166,441,550],[0,2166,441,550],[3846,939,137,201],[3846,397,213,286],[3846,0,219,395],[1282,1444,1280,720],[2564,722,1280,720],[0,722,1280,720],[1282,722,1280,720],[2564,0,1280,720],[0,1444,1280,720],[0,0,1280,720],[1282,0,1280,720]]}
];



lib.updateListCache = function (cacheList) {		
	for(var i = 0; i < cacheList.length; i++) {		
		if(cacheList[i].cacheCanvas)		
			cacheList[i].updateCache();		
	}		
};		

lib.addElementsToCache = function (textInst, cacheList) {		
	var cur = textInst;		
	while(cur != exportRoot) {		
		if(cacheList.indexOf(cur) != -1)		
			break;		
		cur = cur.parent;		
	}		
	if(cur != exportRoot) {	//we have found an element in the list		
		var cur2 = textInst;		
		var index = cacheList.indexOf(cur);		
		while(cur2 != cur) { //insert all it's children just before it		
			cacheList.splice(index, 0, cur2);		
			cur2 = cur2.parent;		
			index++;		
		}		
	}		
	else {	//append element and it's parents in the array		
		cur = textInst;		
		while(cur != exportRoot) {		
			cacheList.push(cur);		
			cur = cur.parent;		
		}		
	}		
};		

lib.gfontAvailable = function(family, totalGoogleCount) {		
	lib.properties.webfonts[family] = true;		
	var txtInst = lib.webFontTxtInst && lib.webFontTxtInst[family] || [];		
	for(var f = 0; f < txtInst.length; ++f)		
		lib.addElementsToCache(txtInst[f], gFontsUpdateCacheList);		

	loadedGoogleCount++;		
	if(loadedGoogleCount == totalGoogleCount) {		
		lib.updateListCache(gFontsUpdateCacheList);		
	}		
};		

lib.tfontAvailable = function(family, totalTypekitCount) {		
	lib.properties.webfonts[family] = true;		
	var txtInst = lib.webFontTxtInst && lib.webFontTxtInst[family] || [];		
	for(var f = 0; f < txtInst.length; ++f)		
		lib.addElementsToCache(txtInst[f], tFontsUpdateCacheList);		

	loadedTypekitCount++;		
	if(loadedTypekitCount == totalTypekitCount) {		
		lib.updateListCache(tFontsUpdateCacheList);		
	}		
};
// symbols:



(lib.ImportedImage = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(0);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_1 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(1);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_10 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(2);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_11 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(3);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_2 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(4);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_3 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(5);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_4 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(6);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_55 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(7);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_5 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(8);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_6 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(9);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_75 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(10);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_7 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(11);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_8 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(12);
}).prototype = p = new cjs.Sprite();



(lib.ImportedImage_9 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(13);
}).prototype = p = new cjs.Sprite();



(lib.Layer1 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(14);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0000 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(15);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0002 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(16);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0005 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(17);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0006 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(18);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0011 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(19);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0014 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(20);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0015 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(21);
}).prototype = p = new cjs.Sprite();



(lib.RabbitRunning0016 = function() {
	this.spriteSheet = ss["rabbit_atlas_"];
	this.gotoAndStop(22);
}).prototype = p = new cjs.Sprite();



(lib.Rabbit = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Layer 1
	this.instance = new lib.RabbitRunning0000();
	this.instance.parent = this;
	this.instance.setTransform(-275,-200);

	this.instance_1 = new lib.RabbitRunning0002();
	this.instance_1.parent = this;
	this.instance_1.setTransform(-275,-200);

	this.instance_2 = new lib.RabbitRunning0005();
	this.instance_2.parent = this;
	this.instance_2.setTransform(-275,-200);

	this.instance_3 = new lib.RabbitRunning0006();
	this.instance_3.parent = this;
	this.instance_3.setTransform(-275,-200);

	this.instance_4 = new lib.RabbitRunning0011();
	this.instance_4.parent = this;
	this.instance_4.setTransform(-275,-200);

	this.instance_5 = new lib.RabbitRunning0014();
	this.instance_5.parent = this;
	this.instance_5.setTransform(-275,-200);

	this.instance_6 = new lib.RabbitRunning0015();
	this.instance_6.parent = this;
	this.instance_6.setTransform(-275,-200);

	this.instance_7 = new lib.RabbitRunning0016();
	this.instance_7.parent = this;
	this.instance_7.setTransform(-275,-200);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance}]}).to({state:[{t:this.instance_1}]},1).to({state:[{t:this.instance_2}]},1).to({state:[{t:this.instance_3}]},1).to({state:[{t:this.instance_4}]},1).to({state:[{t:this.instance_5}]},1).to({state:[{t:this.instance_6}]},1).to({state:[{t:this.instance_7}]},1).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-275,-200,1280,720);


// stage content:
(lib.rabbit = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Frane
	this.shape = new cjs.Shape();
	this.shape.graphics.f().s("#000000").ss(1,1,1).p("EjJUhxUMGSpAAAMAAADipMmSpAAAg");
	this.shape.setTransform(1277.2,725.4);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("rgba(1,1,1,0)").s().p("EjJUBxVMAAAjipMGSpAAAMAAADipg");
	this.shape_1.setTransform(1277.2,725.4);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_1},{t:this.shape}]}).wait(8));

	// Layer 1
	this.instance = new lib.Rabbit("synched",0);
	this.instance.parent = this;
	this.instance.setTransform(1302.6,927.1,4.759,4.759,0,0,180,364.9,160.2);
	this.instance.alpha = 0.289;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(8));

	// Touch up
	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#D7E0DB").s().p("ADPB9IgXgGIgXgHIg7gKQgjgFgVgMQgYgSgOgFQgIgDgNgBQgQgCgHgDIgRgIIgRgIQgJgEgQgBIgZgDQgNgCgTgIIgfgLQgLgEgUgDIgfgEQgmgKgOgZQgJgQAFgUQAFgUAQgKQAUgOAlAFQAYADAnAMQAtAOASADQAPAEAgAEQAbAGARAKQAGgQAWgOIAlgXIASgNIAEgDIAgANQBNAfA6AeIA1AcQAHARgHARQgIAUgTAMQAIAVgFAWQgGAXgSALQgMAIgRAAQgIAAgJgCg");
	this.shape_2.setTransform(1988.3,992.9);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AQvHNQg5gOhJglIhIgmIg1gbQg7gehNggIgggMIhrgqIhwgrQhFgbgngKQgSgFg4gMQgvgKgbgKQgVgHgOgJIgIAAIgwAAQgbgBgUgFIgngPQgQgGgrgHIhwgVQgxgJgXgIQgugPgJgbIgCgBQgPgIgIgCIgagFQgGgCgSgIIhagpIgLgGQg8gHhIgDIi6gHQlngMlfg4QhEgKgeAAIgjAAQgUgBgMgIQgGgEgKgJQgKgJgGgEQgGgDgNgEQgOgDgGgEQgMgHgHgOQgGgOADgPQADgOAMgKQANgKAOgBIAQABQAKABAGgBQAGgBAIgDIANgHQAUgIAsABQArABBXgBQBMABA1AJQAfAFA0ANQA7APAXAFQA6ALBXAGICRAKQBJAHCQAYQCxAeBWAYIATAHQgBgJABgGQACgJAHgGQAHgIAIABQAJAAAIAIIAOAPQAGAIAMALIAVARQANAMACALQABAHgDAHQgEAHgHAAQAAAHAIAHIAQAOIAIgBQAKABANAFIAXALQARAHAjAGIBUAPIAXAFIgGgHQgFgGAAgIQAAgIAFgFQAMgNAhAUQAbATAsALQAQAEBAAMQDYAkDCBmQgFgHAEgKQADgJAIgFQALgHAXgBQA+gCAjABQgMgjAPgiQANgeAkgTQAggSAngCQAggCApAJIBIATQAWAEAHAAIATgCIASgFQAKgCALAAQAAAIADAHQAEAMAKAKQAJAIARAIQAVALAGAEQAKAHASARIASANIABADQAGAdgPAcQgPAbgbANQAUAVAKAaQALAbgBAbQgCAcgQAXQgKAPgNAJIAIAVIAXAFQAZAJAHASQAGAQgKARQgKAQgRAGQgMAFgQAAQgSAAgXgGgAKyCSIACgLIABgDIgiAAQARAHAOAHgAUUA3IgEgGQgNgYgRgMIgKgGIgFgFIgCgCQgPgWgagVQgNgJgKgGQgRgTgQgPQgoghgSgTIgZgcQgQgTgJgJQgMgLgYgSQgagTgKgJQgrgmgFgnQgDgWAJgWQAKgVARgOQASgNAXgEIAIgBIAHgIQAUgUAagFQAYgFAdAJQATAFAfAQIAOAGQAKgEAXgBQAQAAAKAEQAKAEAOANIABABIAEAEIA7A6QAMALAIAJIARAUQAMAQAGAOQAGARgDAOIgBADIAAACIgCAEIADADIADAFIAIAaQADANAFAKIAFgBIALgBIAVgBQAOgDAcgNIABAAIAUgJIACgBQAMgEAIgBQAPgDAcABQALAAASgEIAcgFQATgCAnADIAjgBQAVABAMAIQAJAHAFALIADAHQACAHgBAIQgBAMgHAKQgHAJgLAFQgLAGgbAAIgxAAIgZACIgaAFQgIACgkACQgbABgPAGIgcAOQgXAKgoACIgOABQgFAGgGAGIACADQAMARAEAQQAHAYgIAYQgIAXgTAQQgTAQgZAEIgQABQgQAAgOgFg");
	this.shape_3.setTransform(1931.5,953.1);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#D6E0DA").s().p("Ak+EnQgGgGACgKQABgKAIgGQAGgFAKgDIASgFQAcgHAXgNIAogYQALgHAYgLIAjgTQA4ghA+hJIBph5IAzg4IAQgZQAKgOARgdQAdgxAigzQALgSANABQAHABAFAHQAEAHgBAIQgBAJgMASQgOAVgZApIgWAkIAAAFQgBAHgGAKIA5gBIAGAAIAHgEQAIgDAHABQAGABAEACQAHAEACAJQABAIgEAHQgEAGgNAFIgOAEIhUABQgJAAgEgBIgCgBIAAAAIADACIABACQAFAHgCALQgCAIgIAKIg2BJIgVAdQgLAOgVATQgyAzgqAkIglAdIgEAEIgCADIgFALQgDAIgJACIgDABQgGAAgEgCIgGAGQgtAogvAOQgOAFgLgCQgHgCgEgFQgEgGAAgGQgaAMgkANQgMAEgIAAQgJAAgFgFg");
	this.shape_4.setTransform(1130.8,824.3);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("rgba(1,1,1,0)").s().p("AgTE/QgNgDgKgJQgLgIgFgMIgFgSQgIgEgGgGQgHgGgJgPIgFgIIgOgIIgSgNQgSgRgKgHQgGgEgVgLQgRgIgJgIQgKgKgEgOQgDgHAAgIIABgMQADgOAJgKQAFgGAGgEQAIgLANgHQARgIARACQANACATALQAOAJAJAKIADAFIgIgEQgXgHgSAIQgLAEgIALQgIAKgBAMQgBANAGALQAGALALAGIASAJQAOAGAIAJIAOATIAVAgQAPAVAIAQIALATQAHAKAIAFQALAHALgBQANAAALgHQAKgHAGgMQAFgMgCgNQgBgLgKgVQgKgUgIgLIgVgeIgNgTIAFAFIAKAGQAPAMANAYIAEAGQAPAbACAXQAEAhgUAWQgQAQgTAAIgMgBgAB3hCIgIgaIgEgMIAAgCIABgDIAYAsIALAUIgLABIgFABQgFgKgDgNgADjhIQgBgMgIgNIgMgVIgCgDQgOgfgJgPQgGgKgIgGIgDgMQgKgYgegVIg1gfIgUgNQgMgGgKgCQgLgBgLAEQgJAFgHAIIgCAEIgBgBQABgHADgGQAGgMAIgIQAOgLATgBQAdgEAVAOQAJAHARAVIBRBnIAKAPQAIALACAIQADAJACATIAFAWQADAMAAAJIAAAAIgBABIgBgBg");
	this.shape_5.setTransform(2058.8,938.7);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#B3F69E").s().p("EBJmAL8QgIgFgHgKIgLgSQgIgQgPgVIgVggIgOgTQgIgJgOgHIgSgIQgLgGgGgMQgGgLABgMQABgMAIgLQAIgKALgFQASgIAXAIIAIADIAFADQALAFAMAKQAaAUAPAXIACADIANAUIAXAdQAIALAKAVQAKAVABAKQACANgFAMQgGAMgKAHQgLAHgNABIgBAAQgNAAgKgHgAbUK4IgNgMQgIgIgGgEQgLgHgRgCQgKgBgVAAQgqABgQgPQgIgIgEgLQgDgLACgLQACgLAIgIQAHgJALgEQAJgEARAAIAagCQAAgSANgMQAMgMATAAQAJAAAOAEQAHgIAMgEQASgFAPAIQAPAIAGASQAGARgHAOIAYAZQAVAYAEAYQACAOgEANQgEANgLAJQgOALgbAAIgDAAQgeAAgUgQgEBMCAGLIgYgsQADgPgGgQQgGgPgMgPIgRgUQgIgKgMgKIg7g7IgEgEIACgDQAHgJALgEQALgFALACQAKABAMAHIAUANIA1AfQAeAUAKAZIADALQAHAHAHAKQAJAOAOAfIACAEIAMAUQAIAOABALIABABIgVAJIgBABQgcANgOACIgVACIgLgUgEA0qgCAQgNgFgWgQQgdgVgMgOQgLgMgSgbQgLgRgCgGQgDgLAAgUQAAgWAFgLQAGgNANgHQANgHANACQAOACAKAKQALAKADANIACATQACAOAJAKQAGAHAKAHIASALIAUAQIASAQQAKAKADAKQAHAQgIARQgHAQgSAGQgGACgIAAQgMAAgNgFgEhNQgCcQgNgBgDgJQgFgPAYgOIBSg2QBJgwAfgdIAtgtQAagcAUgOIAUgQQAMgJAHgIIAFgFIACgBQAJgCAEgIIAEgLIADgDIATgOQAJgHANgMQAsgkAygzQAUgTALgOIAWgdIA1hLQAIgKACgIQADgLgFgHQAHgCAIAFQAKAGADALQAFAXgaAiQg6BRhFBIIghAhQgyAyg5AzIg9A1QgjAfgWAZIgZAbQgPAOgNAIQgHAEgNAFIgUAJQgSAJghAbQggAZgUAJQgJADgIAAIgEAAgEA36gHxIgQgKQgFgDgPgDQgagGgZgQQgLgIgNgKIgogfQgbgUgHgPQgFgMABgOQACgOAJgLQAIgKAOgEQAOgEAMAFQALAEAOAOQAnAhAiAVIANAHIASADQAjAFATAYQAKANACAQQACARgIANQgJAOgRAFQgHACgGAAQgLAAgJgFg");
	this.shape_6.setTransform(1585.4,892.5);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f().s("#B3F69E").ss(1,1,1).p("AE1A0QAjgEAmgFAl9gzIAdAcQApAcBAAW");
	this.shape_7.setTransform(885.7,877.8);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#B4F59F").s().p("ABBGpQgZgMgOgEQgIgCgRgBIhKgDQgUgBgLgGIgEAAQgLgCgGgJQgIgLABgRIAAgeQgBgOgJgTIgRggIgJgWIgEgFIgFgTIgMgbIgDgRIgDgOIgBgBIgCgNQgCgKACgLQAAgMAEgJIADgGQADgEADgCQAIgGAKABIAKACIAAAAQAKADAEAJQAGAJgBAJIAAAGIAAADIABALIAGAIIAGAIIAEAIQACABAMACQAOABAMAWQAMAUAOAgQAJATACANQADANgBARIAAAdIgBANIAhABQAjAAASAFQASAFAbAMQAXAKAFAJQAGAKgCANQgEAOgKAFQgIAEgJAAQgLAAgNgGgACMg4QgGgBgEgCQgGgKgIgKQgCgGAAgKIABgmQACgdgCgLIgJgfQgDgMgDgXQgLhLgTgvQgIgTgBgIQgEgQAHgLQAJgNANgBQAPgDAJAMQAHAFAEAQIAJAdIAEgBQAOgBAJALQAFAFAEAKQADAKADAUIAIARQADAKACALQAKAlAAAWQACASgBAhIACAjQACAXgBAMQgCAYgLALQgJAIgMgCQgGABgFgCQgEACgGAAIgEAAg");
	this.shape_8.setTransform(1985,1173.4);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#D6E0DB").s().p("ACTD1Qg7gZgmgZQgygigYgqIgWglQgEgFgcgdQgSgUgWghIgkg6Qglg0g/g7QgPgLgEgGQgJgLgDgJQgFgMAFgMQAGgOALgDQARgEAWAWIAuAuQBDBHAhA1IAVAkQANAUAMALIASARIAQASIAJANQAFAEAPADQAdAEAdAUIhhhgQgVgWABgPQABgKAJgIQAJgIALgBQARgBAXAOQAHAEAMAJIATAKQgEgGAAgKQgBgIAEgJQAGgMASgLQAUgMAOAEQAEAAARANIARANQAIAGANASQAHAIAUARQAaAsAqBFIgDAFQgNARgUgEQAHAMASAXQAOAZgBARQgBAMgHAIQgHAKgLACQgMACgNgJQgKgHgKgMIgyg7QgBAKgIAHIgIAFIAwA1QASATgCANQgBAKgJAGQgIAGgLABIgEAAQgNAAgVgJg");
	this.shape_9.setTransform(1906.3,1200.6);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AFMJ3QgMgHgJgLQgNgRgCgQIgBgTIAAgRQgDgVgSgYIgjgoQgLgOgXglIgNgVQgphFgagvQgMgSgJgPQgTgigEgWQgEgPAEgPQAEgPALgLQgQgRgBgRQgBgLAFgIQAFgKAIgEQASgHASAPQAJAIAPAUQAbAkAmAcQgWgfgGgPQgLgfANgWQgWgOgIgPQgEgKABgMQABgJAHgHQAPgMAVAJQAHADAYAPQAbAUBEAmQA+AjAdAaQAQAPAIACIANABQAIAAAGADQAJADAEAOIAGAaQACALAHASIABABIAMAcIAFASQAFAZgIARQgGAPgQAGQgQAGgMgIQgBALAJAjQAFAdgFAPIgHAPIgHAOQgDAHAAAWQAAATgGAJQgIALgbAIQgdAIgIALQgIALABAWIAAAfQgDATgOAGQgFADgGAAQgGAAgHgDgAEtEtQAJASAGAGIgSgmQgFgMgHgEgAJzCnQgIgJgNgXIgihJQgxhhgegyIgpg6Igog7IgRgdQgJgOAAgLQgBgNAKgKQAKgJALgBIgIgUIgKgUQgLgaALgQQAEgJAOgMIAMgQQAKgHASgCQAygEA2AZQAuAWAqApQAKAKAHAAQAHgBAMgIQANgEAMAKQAHAFAKARIAtBNQAaArADAbQACAUgJARQgJATgQAHIAmArIAEAEQAIAKAGAKQAIAMAHAMQALAQABAPQABAWgOAKQgSAMgVgNQgMgJgOgVQgEAMgOAFQgPAEgNgHQgRgIgSghQAGA6gBA3QgBAbgGAOQgJAXgVACIgDAAQgQAAgOgOgAHri8IADADIANAJIgDgEIgKgLIgDgCQgBABABAEgAp6k4QgdgJgQgYQgEgIgDgDQgFgHgGgCQgDgCgIgBIgJgDQgLgDgLgMIghghQgNgNgGgIQgIgMgBgNIABgTQABgMgDgHQgBgFgMgNQgJgJgLgOQgUgZAFgRQACgGAFgGIAHgLIALgRQAJgJAYADQAfAEAzARQA5ATAYAFIAjAIQATAJAHAPQAFANgGANQgEAKgJAFQgJAFgLgCQgFgBgIgFIgKgHQgJgFgTgCQgTgCgJgFQAgAhAmAdQAVAPAGAIQAPAQgBASQAAAJgFAHQgGAJgJACQgMAEgRgKQgQgMgKgEQAGAKAWASQATAPAFANQAFANgEAOQgFAOgNAGQgFACgGAAQgGAAgIgDg");
	this.shape_10.setTransform(1915.6,1170.1);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#B3F69E").s().p("AB4A4QgsAAgWgCQg0gIgYgDIglgDQgXgCgOgDQgKgDgogQQgfgNgUAAIgZABQgPABgJgBQgNgCgJgGQgKgJAAgMIAAgCQABgIAHgIQAHgHALgDQAJgDAgABIAbAAQAPABALACQAPAEAdAOQATAIAuAGQBNAKAnADQBBAFA1gCQAYgBANgFIAOgGQAIgEAHAAQAJgBAIAGQAHAFADAIIAAACQAEANgMARQgOARgcAGQgPADghAAg");
	this.shape_11.setTransform(888.8,883.4);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_6},{t:this.shape_5},{t:this.shape_4},{t:this.shape_3},{t:this.shape_2}]}).to({state:[{t:this.shape_11},{t:this.shape_10},{t:this.shape_9},{t:this.shape_8},{t:this.shape_7}]},1).to({state:[]},1).wait(6));

	// Head
	this.instance_1 = new lib.ImportedImage();
	this.instance_1.parent = this;
	this.instance_1.setTransform(1479.8,63.9,1,1,-10);

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(1).to({rotation:-3,x:1548.9,y:84.8},0).wait(1).to({rotation:-18,x:1427,y:244.2},0).wait(1).to({x:1403.4,y:223.6},0).wait(1).to({rotation:-24.7,x:1305.7,y:289.8},0).wait(1).to({rotation:-27.7,x:1348.3,y:330.9},0).wait(1).to({rotation:-32.4,x:1247.8,y:237.9},0).wait(1).to({rotation:-20.2,x:1336.6,y:107.9},0).wait(1));

	// Layer 19
	this.instance_2 = new lib.ImportedImage_75();
	this.instance_2.parent = this;
	this.instance_2.setTransform(521.2,808.2,1,0.833,0,-63.1,-39.2);

	this.instance_3 = new lib.ImportedImage_7();
	this.instance_3.parent = this;
	this.instance_3.setTransform(611.6,431.8,1.17,0.854,0,-12.8,0);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_2}]}).to({state:[{t:this.instance_3,p:{scaleX:1.17,scaleY:0.854,skewX:-12.8,skewY:0,x:611.6,y:431.8}}]},1).to({state:[{t:this.instance_2}]},1).to({state:[{t:this.instance_2}]},1).to({state:[{t:this.instance_2}]},1).to({state:[{t:this.instance_2}]},1).to({state:[{t:this.instance_3,p:{scaleX:0.871,scaleY:0.746,skewX:-25.7,skewY:-18.6,x:790.8,y:666.1}}]},1).to({state:[{t:this.instance_3,p:{scaleX:0.848,scaleY:0.76,skewX:6.1,skewY:7.3,x:875.5,y:592.8}}]},1).wait(1));
	this.timeline.addTween(cjs.Tween.get(this.instance_2).to({_off:true},1).wait(1).to({_off:false,scaleX:1.04,scaleY:0.83,skewX:-77.8,skewY:-59.4,x:715.5,y:872.5},0).wait(1).to({scaleX:0.89,scaleY:0.86,skewX:-84.1,skewY:-63.1,x:962.4,y:965.8},0).wait(1).to({scaleX:0.88,scaleY:0.83,skewX:-69.8,skewY:-56.1,x:998.3,y:928.1},0).wait(1).to({scaleX:0.83,scaleY:0.77,skewX:-30.4,skewY:-17.2,x:933.6,y:713.5},0).to({_off:true},1).wait(2));

	// Layer 22
	this.instance_4 = new lib.ImportedImage_6();
	this.instance_4.parent = this;
	this.instance_4.setTransform(686.3,620.3,1,0.898,35.7);

	this.timeline.addTween(cjs.Tween.get(this.instance_4).wait(1).to({scaleX:1.05,scaleY:0.99,x:643.2,y:517.6},0).wait(1).to({x:973.2,y:547.6},0).wait(1).to({scaleX:0.72,scaleY:0.72,rotation:24.7,x:1169.1,y:797.7},0).wait(1).to({scaleX:0.76,scaleY:0.68,rotation:0,skewX:-15.3,skewY:-18.5,x:1189.8,y:927.3},0).wait(1).to({scaleX:0.78,scaleY:0.67,skewX:-15.6,skewY:-22,x:1028,y:941.6},0).wait(1).to({scaleX:0.51,scaleY:0.6,skewX:14.4,skewY:4.6,x:908.6,y:881.8},0).wait(1).to({scaleX:0.82,scaleY:1.08,skewX:24.7,skewY:4.8,x:753.3,y:810.4},0).wait(1));

	// Layer 24
	this.instance_5 = new lib.ImportedImage_55();
	this.instance_5.parent = this;
	this.instance_5.setTransform(462.4,862.3,1,1,165);

	this.instance_6 = new lib.ImportedImage_5();
	this.instance_6.parent = this;
	this.instance_6.setTransform(1209.3,1221.1,1,1,6.5);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_5}]}).to({state:[{t:this.instance_5}]},1).to({state:[{t:this.instance_5}]},1).to({state:[{t:this.instance_5}]},1).to({state:[{t:this.instance_5}]},1).to({state:[{t:this.instance_6,p:{x:1209.3,y:1221.1,rotation:6.5}}]},1).to({state:[{t:this.instance_6,p:{x:870,y:1187.9,rotation:6.5}}]},1).to({state:[{t:this.instance_6,p:{x:685.2,y:1153.3,rotation:81.5}}]},1).wait(1));
	this.timeline.addTween(cjs.Tween.get(this.instance_5).wait(1).to({rotation:135,x:521.2,y:854.3},0).wait(1).to({rotation:67,x:989.8,y:969.1},0).wait(1).to({rotation:41,x:1249,y:999},0).wait(1).to({rotation:26,x:1465.8,y:1107.4},0).to({_off:true},1).wait(3));

	// Layer 23
	this.instance_7 = new lib.ImportedImage_4();
	this.instance_7.parent = this;
	this.instance_7.setTransform(607.5,676.2,1.643,1.295,0,74.6,32.5);

	this.timeline.addTween(cjs.Tween.get(this.instance_7).wait(1).to({scaleX:1.06,skewX:35.9,skewY:24.5,x:572.3,y:554.3},0).wait(1).to({scaleX:1.11,scaleY:1.33,skewX:-18.2,skewY:-25.1,x:776.1,y:753.7},0).wait(1).to({skewX:-44.3,skewY:-51.1,x:962.4,y:899.3},0).wait(1).to({skewX:-53,skewY:-59.9,x:1171.8,y:1042.2},0).wait(1).to({skewX:-33.3,skewY:-40.2,x:1004,y:1029.3},0).wait(1).to({scaleX:0.98,skewX:-5.3,skewY:-12.6,x:831.1,y:915.6},0).wait(1).to({skewX:24.7,skewY:17.4,x:684.9,y:881.8},0).wait(1));

	// Layer 15
	this.instance_8 = new lib.ImportedImage_11();
	this.instance_8.parent = this;
	this.instance_8.setTransform(1459.8,692.6,0.793,0.793,-30);

	this.timeline.addTween(cjs.Tween.get(this.instance_8).wait(1).to({rotation:-6.5,x:1529.1,y:707.1},0).wait(1).to({rotation:14.8,x:1637.6,y:707.4},0).wait(1).to({rotation:38.7,x:1732,y:693.4},0).wait(1).to({rotation:4.2,x:1627.4,y:663.5},0).wait(1).to({rotation:15.2,x:1791.4,y:688.8},0).wait(1).to({scaleX:0.79,scaleY:0.68,rotation:0,skewX:17.9,skewY:12.9,x:1730.4,y:597.4},0).wait(1).to({skewX:-3,skewY:-8.1,x:1704,y:592.3},0).wait(1));

	// Layer 17
	this.instance_9 = new lib.ImportedImage_10();
	this.instance_9.parent = this;
	this.instance_9.setTransform(2044.6,902.2,1,1,32);

	this.timeline.addTween(cjs.Tween.get(this.instance_9).wait(1).to({rotation:55.6,x:1990,y:1145.6},0).wait(1).to({x:1852.9,y:1196.8},0).wait(1).to({rotation:160.6,x:1586.3,y:1256.7},0).wait(1).to({rotation:185.5,x:1763.2,y:1208.3},0).wait(1).to({x:2022.3,y:1221.1},0).wait(1).to({x:1967.2,y:1059.5},0).wait(1).to({rotation:164.6,x:2100.3,y:926.3},0).wait(1));

	// Layer 18
	this.instance_10 = new lib.ImportedImage_8();
	this.instance_10.parent = this;
	this.instance_10.setTransform(1862.2,982.7,1,0.926,-68);

	this.timeline.addTween(cjs.Tween.get(this.instance_10).wait(1).to({rotation:-44.5,x:1790.6,y:1146.6},0).wait(1).to({rotation:-29.5,x:1667.5,y:1157.2},0).wait(1).to({rotation:45.5,x:1594,y:1048.8},0).wait(1).to({rotation:0,skewX:78.8,skewY:-101.2,x:1887.2,y:1159.6},0).wait(1).to({scaleX:1.01,scaleY:1.4,skewX:-85.7,skewY:-80.2,x:1739.8,y:1135.2},0).wait(1).to({x:1682.3,y:984.3},0).wait(1).to({skewX:-106.7,skewY:-101.2,x:1807.4,y:958},0).wait(1));

	// Layer 16
	this.instance_11 = new lib.ImportedImage_9();
	this.instance_11.parent = this;
	this.instance_11.setTransform(1645.8,862.2,1,1,-45);

	this.timeline.addTween(cjs.Tween.get(this.instance_11).wait(1).to({rotation:-21.5,x:1640.4,y:949.7},0).wait(1).to({rotation:15.5,x:1661.4,y:883.6},0).wait(1).to({rotation:53.2,x:1725.6,y:862.1},0).wait(1).to({rotation:-36.8,x:1623.1,y:979.3},0).wait(1).to({rotation:49.5,x:1894.7,y:835.6},0).wait(1).to({x:1819.2,y:688.2},0).wait(1).to({rotation:28.5,x:1829.3,y:632.5},0).wait(1));

	// Butt
	this.instance_12 = new lib.ImportedImage_1();
	this.instance_12.parent = this;
	this.instance_12.setTransform(670.6,235.8,1,1,15);

	this.timeline.addTween(cjs.Tween.get(this.instance_12).wait(1).to({rotation:23.9,x:726.8,y:141},0).wait(1).to({rotation:12.2,x:787.6,y:244.7},0).wait(1).to({rotation:-10.7,x:835.7,y:427.5},0).wait(1).to({x:815.8,y:465.4},0).wait(1).to({rotation:-2.7,x:847.2,y:444.3},0).wait(1).to({rotation:-8.9,x:683,y:477.3},0).wait(1).to({rotation:-0.9,x:662.6,y:455.9},0).wait(1));

	// Neck
	this.instance_13 = new lib.ImportedImage_3();
	this.instance_13.parent = this;
	this.instance_13.setTransform(1626.5,485.3,1,1,7);

	this.timeline.addTween(cjs.Tween.get(this.instance_13).wait(1).to({rotation:18.2,x:1677.4,y:554.3},0).wait(1).to({rotation:9.7,x:1696.7,y:596.1},0).wait(1).to({scaleX:0.83,rotation:0.2,x:1694.5,y:623},0).wait(1).to({scaleX:0.74,rotation:0,skewX:0.2,skewY:0.3,x:1715.4,y:615.8},0).wait(1).to({scaleX:0.84,skewX:15.2,skewY:15.3,x:1777.6,y:582.7},0).wait(1).to({x:1752.5,y:456.9},0).wait(1).to({skewX:0.2,skewY:0.3,x:1731.8,y:414.5},0).wait(1));

	// Chest
	this.instance_14 = new lib.ImportedImage_2();
	this.instance_14.parent = this;
	this.instance_14.setTransform(1376,501.4,1,0.911,15);

	this.timeline.addTween(cjs.Tween.get(this.instance_14).wait(1).to({x:1429.9,y:597.4},0).wait(1).to({y:645},0).wait(1).to({x:1453.5,y:615.8},0).wait(1).to({rotation:39,x:1610.6,y:513.8},0).wait(1).to({scaleY:0.98,rotation:24,x:1576.5,y:535.4},0).wait(1).to({rotation:9,x:1419.2,y:494.1},0).wait(1).to({scaleY:0.79,rotation:-6,x:1413.2,y:575.6},0).wait(1));

	// Torso
	this.instance_15 = new lib.Layer1();
	this.instance_15.parent = this;
	this.instance_15.setTransform(1123.1,499.7,1.517,0.81,0,8,9.3);

	this.timeline.addTween(cjs.Tween.get(this.instance_15).wait(1).to({scaleX:3.08,scaleY:1.03,skewX:18.4,skewY:17.3,x:1040.4,y:438.7},0).wait(1).to({scaleX:2.34,scaleY:1.2,skewX:33.4,skewY:27.8,x:1238.8,y:450.9},0).wait(1).to({scaleY:1.36,skewX:50.3,skewY:33.8,x:1358.8,y:393.2},0).wait(1).to({scaleX:1.7,scaleY:0.78,skewX:57.6,skewY:41,x:1394.2,y:483.1},0).wait(1).to({scaleX:1.8,scaleY:1.01,skewX:1.9,skewY:8.2,x:1291.3,y:519.1},0).wait(1).to({scaleX:2.82,scaleY:1.08,skewX:-13.2,skewY:2.3,x:1057,y:501.5},0).wait(1).to({scaleX:3.14,scaleY:0.93,skewX:-1.2,skewY:-3.7,x:1111.6,y:596.9},0).wait(1));

	// Layer 22
	this.instance_16 = new lib.ImportedImage_6();
	this.instance_16.parent = this;
	this.instance_16.setTransform(665.3,602.5,1,0.898,35.7);

	this.timeline.addTween(cjs.Tween.get(this.instance_16).wait(1).to({scaleX:1.05,scaleY:0.99,x:683.2,y:517.6},0).wait(1).to({x:1005.1,y:507.8},0).wait(1).to({rotation:9.7,x:1096.8,y:658.2},0).wait(1).to({scaleX:0.69,scaleY:0.69,rotation:0,skewX:-15.3,skewY:-18.5,x:1227.3,y:939.9},0).wait(1).to({scaleX:0.7,scaleY:0.68,skewX:-15.6,skewY:-22,x:1079.9,y:945.7},0).wait(1).to({scaleX:0.45,scaleY:0.54,skewX:11.4,skewY:4.5,x:938.4,y:899.2},0).wait(1).to({scaleX:0.72,scaleY:0.97,skewX:22.1,skewY:4.7,x:796.1,y:839.6},0).wait(1));

	// Layer 23
	this.instance_17 = new lib.ImportedImage_4();
	this.instance_17.parent = this;
	this.instance_17.setTransform(661.2,679.2,1.185,1.295,0,74.6,41.6);

	this.instance_18 = new lib.ImportedImage_55();
	this.instance_18.parent = this;
	this.instance_18.setTransform(561.2,854.3,1,1,135);
	this.instance_18._off = true;

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_17}]}).to({state:[{t:this.instance_18}]},1).to({state:[{t:this.instance_18}]},1).to({state:[{t:this.instance_18}]},1).to({state:[{t:this.instance_18}]},1).to({state:[{t:this.instance_18}]},1).to({state:[{t:this.instance_18}]},1).to({state:[{t:this.instance_18}]},1).wait(1));
	this.timeline.addTween(cjs.Tween.get(this.instance_18).wait(1).to({_off:false},0).wait(1).to({rotation:67,x:1004.8,y:932},0).wait(1).to({rotation:41,x:1246.3,y:959.1},0).wait(1).to({rotation:26,x:1488.3,y:1093.4},0).wait(1).to({rotation:6.5,x:1229.2,y:1200.4},0).wait(1).to({x:889.9,y:1167.2},0).wait(1).to({rotation:81.5,x:710.4,y:1167.1},0).wait(1));

	// Layer 24
	this.instance_19 = new lib.ImportedImage_55();
	this.instance_19.parent = this;
	this.instance_19.setTransform(480.8,848.4,1,0.691,165);

	this.instance_20 = new lib.ImportedImage_4();
	this.instance_20.parent = this;
	this.instance_20.setTransform(612.3,554.3,1.058,1.295,0,35.9,24.5);
	this.instance_20._off = true;

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_19}]}).to({state:[{t:this.instance_20}]},1).to({state:[{t:this.instance_20}]},1).to({state:[{t:this.instance_20}]},1).to({state:[{t:this.instance_20}]},1).to({state:[{t:this.instance_20}]},1).to({state:[{t:this.instance_20}]},1).to({state:[{t:this.instance_20}]},1).wait(1));
	this.timeline.addTween(cjs.Tween.get(this.instance_20).wait(1).to({_off:false},0).wait(1).to({scaleX:1.11,scaleY:1.33,skewX:-18.2,skewY:-25.1,x:802.1,y:722.5},0).wait(1).to({skewX:-44.3,skewY:-51.1,x:972.2,y:859.9},0).wait(1).to({skewX:-53,skewY:-59.9,x:1192.8,y:1021.6},0).wait(1).to({skewX:-33.3,skewY:-40.2,x:1030.8,y:1017},0).wait(1).to({scaleX:0.98,skewX:-5.3,skewY:-12.6,x:857.1,y:917.8},0).wait(1).to({skewX:24.7,skewY:17.4,x:706.3,y:896.7},0).wait(1));

	// Layer 17
	this.instance_21 = new lib.ImportedImage_10();
	this.instance_21.parent = this;
	this.instance_21.setTransform(2064.6,864.8,1,1,32);

	this.instance_22 = new lib.ImportedImage_11();
	this.instance_22.parent = this;
	this.instance_22.setTransform(1450.8,742.7,0.793,0.793,-21.5);
	this.instance_22._off = true;

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_21}]}).to({state:[{t:this.instance_22}]},1).to({state:[{t:this.instance_22}]},1).to({state:[{t:this.instance_22}]},1).to({state:[{t:this.instance_22}]},1).to({state:[{t:this.instance_22}]},1).to({state:[{t:this.instance_22}]},1).to({state:[{t:this.instance_22}]},1).wait(1));
	this.timeline.addTween(cjs.Tween.get(this.instance_22).wait(1).to({_off:false},0).wait(1).to({rotation:-0.2,x:1556,y:710.1},0).wait(1).to({rotation:23.8,x:1656.3,y:662.7},0).wait(1).to({rotation:-10.7,x:1547.7,y:681.1},0).wait(1).to({rotation:0.2,x:1710.5,y:691},0).wait(1).to({scaleY:0.67,rotation:0,skewX:0.3,skewY:0.2,x:1649.5,y:598.9},0).wait(1).to({skewX:-20.7,skewY:-20.8,x:1629,y:622.7},0).wait(1));

	// Layer 15
	this.instance_23 = new lib.ImportedImage_11();
	this.instance_23.parent = this;
	this.instance_23.setTransform(1479.8,653.2,0.793,0.793,-30);

	this.instance_24 = new lib.ImportedImage_10();
	this.instance_24.parent = this;
	this.instance_24.setTransform(2014.7,1099.5,1,1,55.6);
	this.instance_24._off = true;

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_23}]}).to({state:[{t:this.instance_24}]},1).to({state:[{t:this.instance_24}]},1).to({state:[{t:this.instance_24}]},1).to({state:[{t:this.instance_24}]},1).to({state:[{t:this.instance_24}]},1).to({state:[{t:this.instance_24}]},1).to({state:[{t:this.instance_24}]},1).wait(1));
	this.timeline.addTween(cjs.Tween.get(this.instance_24).wait(1).to({_off:false},0).wait(1).to({x:1877.6,y:1150.7},0).wait(1).to({rotation:160.6,x:1638,y:1244.5},0).wait(1).to({rotation:185.5,x:1814.1,y:1181.2},0).wait(1).to({x:2062.2,y:1194},0).wait(1).to({x:2007.1,y:1032.4},0).wait(1).to({rotation:164.6,x:2127.9,y:886.7},0).wait(1));

	// Layer 18
	this.instance_25 = new lib.ImportedImage_8();
	this.instance_25.parent = this;
	this.instance_25.setTransform(1882.2,945.3,1,0.926,-68);

	this.timeline.addTween(cjs.Tween.get(this.instance_25).wait(1).to({rotation:-44.5,x:1815.3,y:1100.5},0).wait(1).to({rotation:-29.5,x:1703.2,y:1119.1},0).wait(1).to({rotation:45.5,x:1617.9,y:1039.7},0).wait(1).to({rotation:0,skewX:78.8,skewY:-101.2,x:1908.3,y:1145},0).wait(1).to({scaleX:1.01,scaleY:1.4,skewX:-85.7,skewY:-80.2,x:1772.6,y:1122.7},0).wait(1).to({x:1715.1,y:971.8},0).wait(1).to({skewX:-106.7,skewY:-101.2,x:1833.5,y:934.6},0).wait(1));

	// Layer 16
	this.instance_26 = new lib.ImportedImage_9();
	this.instance_26.parent = this;
	this.instance_26.setTransform(1661.8,824.8,1,1,-45);

	this.timeline.addTween(cjs.Tween.get(this.instance_26).wait(1).to({rotation:-21.5,x:1665.1,y:903.5},0).wait(1).to({rotation:15.5,x:1708.9,y:861.6},0).wait(1).to({rotation:53.2,x:1756.5,y:851.8},0).wait(1).to({rotation:-36.8,x:1644.8,y:948.4},0).wait(1).to({rotation:49.5,x:1908.4,y:827.1},0).wait(1).to({x:1832.9,y:679.8},0).wait(1).to({rotation:28.5,x:1829.3,y:632.5},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-464,-67.2,6092.1,3426.8);

})(lib = lib||{}, images = images||{}, createjs = createjs||{}, ss = ss||{});
var lib, images, createjs, ss;