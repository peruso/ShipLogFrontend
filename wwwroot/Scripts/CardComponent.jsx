

class CardComponent extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            id: this.props.cardData.id,

        };
        console.log(this.props.cardData.name);

        console.log(this.state.id);
    }

    render() {
        var baseurl = "http://localhost:5242/";
        var cardStyle = {
            //width: '50%',
            marginBottom: '10px',
            marginTop: '5px',
            paddingBottom: '10px',
            paddingTop: '5px',
            boxShadow: '0 4px 8px rgba(0,0,0,0.1)',
            borderRadius: '8px',
        };
        var imageStyle = {

            padding: '10px',
            //objectFit: 'cover',  // イメージが親要素に収まるように調整
            borderRadius: '20px',
        };
        var pSyle = {
            marginBottom: '0px',
        };

        var submitChange = () => {
            //to redirect to edit page
            console.log(this.props.cardData.shipInfoId);

            //window.location.href = baseurl + this.state.id;
            window.location.href = baseurl + "Home/Edit/" + this.state.id;


        }
        var submitDelete = () => {
            //to send delete request by ajax
            console.log("Cliecked Delete");
            console.log(this.state.id);

            $.ajax({
                url: ShipReviewsURL + "/" + this.state.id,
                type: "DELETE",
                success: function () {
                    console.log("DELETE request successful");
                    window.location.reload();
                },
                error: function (jqRequest, status, error) {
                    console.log(status);
                    console.log(jqRequest);
                    console.log(error);
                }
            });
        }
            //var imageStyle = {
            //    width: '50%',  // イメージの幅を50%に設定
            //    height: 'auto',  // 高さは自動調整
            //    objectFit: 'cover',  // イメージが親要素に収まるように調整
            //};

            return (
                <div className="card" style={cardStyle}>
                    <img src={this.props.cardData.photo} alt="Card Image" style={imageStyle} />
                    <div className="card-body">
                        <h3 className="card-title">{this.props.cardData.name}</h3>
                        <p className="card-text" style={pSyle}>Vessel Type: {this.props.cardData.type}</p>
                        <p className="card-text" style={pSyle}>IMO No: {this.props.cardData.imo}</p>
                        <p className="card-text" style={pSyle}>Flag: {this.props.cardData.flag}</p>
                        <p className="card-text" style={pSyle}>Gross Ton: {this.props.cardData.grossTon}</p>
                        <p className="card-text" style={pSyle}>DWT: {this.props.cardData.dwt}</p>
                        <p className="card-text" style={pSyle}>Length: {this.props.cardData.length}</p>
                        <p className="card-text" style={pSyle}>Beam: {this.props.cardData.beam}</p>
                        <p className="card-text" style={pSyle}>Draught: {this.props.cardData.draught}</p>
                        <p className="card-text" style={pSyle}>Build Year: {this.props.cardData.buildYear}</p>
                        <p className="card-text" style={pSyle}>Owner: {this.props.cardData.owner}</p>
                        <p className="card-text" style={pSyle}>Manager: {this.props.cardData.manager}</p>




                    </div>



                    <EvaluationProgressBar
                        vesselQualityValue={this.props.cardData.vesselQualityValue}
                        crewPerformanceValue={this.props.cardData.crewPerformanceValue}
                        crewAttitudeValue={this.props.cardData.crewAttitudeValue}
                        fuelEfficiencyValue={this.props.cardData.fuelEfficiencyValue}
                        safetyScoreValue={this.props.cardData.safetyScoreValue}
                    />

                    <div className="card-footer">
                        <button onClick={submitChange} className="btn btn-sm btn-primary" style={{ marginRight: '10px' }}>Edit</button>



                        <button onClick={submitDelete} className="btn btn-sm btn-danger">Delete</button>
                    </div>
                    <br></br>
                    <br></br>
                </div>
            );
        
    }
}

